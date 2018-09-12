namespace ShipServer.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentSiren.Builders;
    using LiteDB;
    using Microsoft.AspNetCore.Mvc;
    using Model;

    [Route("api/starshipclass")]
    [ApiController]
    public class StarShipClassController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<StarshipClass>> Get()
        {
            var baseUrl = GetBaseUrl();

            using (var db = new LiteDatabase(@"ships.db"))
            {
                var col = db.GetCollection<StarshipClass>("ShipClass");
                var classes = col.FindAll();

                var sirenEntity = new EntityBuilder()
                    .WithClass("starshipClass")
                    .WithClass("collection")
                    .WithProperty("classCount", classes.Count())
                    .WithLink(new LinkBuilder()
                        .WithRel("self")
                        .WithHref($"{baseUrl}/api/starshipclass"));

                foreach (var @class in classes)
                    sirenEntity.WithSubEntity(new EmbeddedLinkBuilder()
                        .WithClass("starshipClass")
                        .WithRel($"{baseUrl}/rels/starship-class")
                        .WithHref($"{baseUrl}/api/starshipclass/{@class.Id}"
                        ));

                return Ok(sirenEntity.Build());
            }
        }

        [HttpGet("{id}")]
        public ActionResult<StarshipClass> Get(Guid id)
        {
            var baseUrl = GetBaseUrl();

            using (var db = new LiteDatabase(@"ships.db"))
            {
                var col = db.GetCollection<StarshipClass>("ShipClass");
                var @class = col.FindById(id);

                var sirenEntity = new EntityBuilder()
                    .WithClass("starshipClass")
                    .WithProperty("name", @class.Name)
                    .WithLink(new LinkBuilder()
                        .WithRel("self")
                        .WithHref($"{baseUrl}/api/starshipclass/{id}"));

                foreach (var ship in @class.Ships)
                    sirenEntity.WithSubEntity(new EmbeddedLinkBuilder()
                        .WithClass("starship")
                        .WithRel($"{baseUrl}/rels/starship")
                        .WithHref($"{baseUrl}/api/starshipclass/{@class.Id}/ships/{ship.Id}"
                        ));

                return Ok(sirenEntity.Build());
            }
        }

        [HttpGet("{id}/ships/{shipId}")]
        public ActionResult<Starship> GetStarship(Guid id, Guid shipId)
        {
            var baseUrl = GetBaseUrl();

            using (var db = new LiteDatabase(@"ships.db"))
            {
                var col = db.GetCollection<StarshipClass>("ShipClass");
                var @class = col.FindById(id);
                var ship = @class.Ships.Single(x => x.Id == shipId);

                var sirenEnity = new EntityBuilder()
                    .WithClass("starship")
                    .WithProperty("name", ship.Name)
                    .WithProperty("registry", ship.Registry)
                    .WithProperty("details", ship.Details)
                    .WithLink(new LinkBuilder()
                        .WithRel("self")
                        .WithHref($"{baseUrl}/api/starshipclass/{@class.Id}/ships/{ship.Id}"))
                    .WithAction(new ActionBuilder()
                        .WithName("report-missing")
                        .WithTitle("Report Missing")
                        .WithHref($"{baseUrl}/api/starshipclass/{@class.Id}/ships/{ship.Id}/reportmissing")
                        .WithType("application/json")
                        .WithMethod("POST")
                        .WithField(new FieldBuilder()
                            .WithName("report")
                            .WithType("text")));

                return Ok(sirenEnity.Build());
            }
        }

        [HttpPost("{id}/ships/{shipId}/reportmissing")]
        public IActionResult PostMissingReport([FromBody] object value)
        {
            return Accepted($"{GetBaseUrl()}/api/missingreport/{Guid.NewGuid()}");
        }

        private string GetBaseUrl()
        {
            return $"{Request.Scheme}://{Request.Host.Value}";
        }
    }
}
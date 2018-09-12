namespace ShipServer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using LiteDB;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Model;
    using Newtonsoft.Json;

    public static class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists(@"ships.db")) PopulateData();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }

        private static void PopulateData()
        {
            var json = File.ReadAllText(@"ships.json");

            var ships = JsonConvert.DeserializeObject<List<Ship>>(json);

            using (var db = new LiteDatabase(@"ships.db"))
            {
                var col = db.GetCollection<StarshipClass>("ShipClass");

                var classes = ships.Select(x => x.Class).Distinct().ToArray();

                foreach (var @class in classes)
                    col.Insert(new StarshipClass
                    {
                        Id = Guid.NewGuid(),
                        Name = @class,
                        Ships = (from ship in ships
                            where ship.Class == @class
                            select new Starship
                            {
                                Id = Guid.NewGuid(),
                                Name = ship.Name,
                                Details = ship.Details,
                                Registry = ship.Registry
                            }).ToList()
                    });
            }
        }
    }
}
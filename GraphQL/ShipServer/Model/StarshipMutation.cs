namespace ShipServer.Model
{
    using GraphQL.Types;
    using LiteDB;

    public class StarshipMutation : ObjectGraphType
    {
        public StarshipMutation()
        {
            Field<StarshipType>(
                "createStarship",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StarshipInputType>> {Name = "starship"}),
                resolve: context =>
                {
                    var starship = context.GetArgument<Starship>("starship");
                    using (var db = new LiteDatabase(@"ships.db"))
                    {
                        var col = db.GetCollection<Starship>("Starships");
                        col.Insert(starship);
                        return starship;
                    }
                });
        }
    }
}
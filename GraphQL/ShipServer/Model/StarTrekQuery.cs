namespace ShipServer.Model
{
    using System.Linq;
    using GraphQL.Types;
    using LiteDB;

    public class StarTrekQuery : ObjectGraphType
    {
        public StarTrekQuery()
        {
            Field<ListGraphType<StarshipType>>(
                "starship",
                arguments: new QueryArguments(new QueryArgument<StringGraphType> {Name = "class"}),
                resolve: context =>
                {
                    using (var db = new LiteDatabase(@"ships.db"))
                    {
                        var col = db.GetCollection<Starship>("Starships");
                        var @class = context.GetArgument<string>("class");
                        if (@class == null)
                        {
                            return col.FindAll().OrderBy(x => x.Class).ThenBy(x => x.Name);
                        }
                        return col.FindAll().Where(x => x.Class.ToLower() == @class.ToLower()).OrderBy(x => x.Name);
                    }
                });
        }
    }
}
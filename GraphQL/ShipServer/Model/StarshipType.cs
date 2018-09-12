namespace ShipServer.Model
{
    using GraphQL.Types;

    public class StarshipType : ObjectGraphType<Starship>
    {
        public StarshipType()
        {
            Field(x => x.Class);
            Field(x => x.Name);
            Field(x => x.Registry, nullable: true);
            Field(x => x.Details, nullable: true);
        }
    }
}

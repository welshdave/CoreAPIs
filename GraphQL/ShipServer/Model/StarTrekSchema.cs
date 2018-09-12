namespace ShipServer.Model
{
    using GraphQL.Types;

    public class StarTrekSchema : Schema
    {
        public StarTrekSchema(StarTrekQuery query, StarshipMutation mutation)
        {
            Query = query;
            Mutation = mutation;
        }
    }
}

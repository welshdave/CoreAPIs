namespace ShipServer.Model
{
    using GraphQL.Types;

    public class StarshipInputType : InputObjectGraphType
    {
        public StarshipInputType()
        {
            Name = "StarshipInput";
            Field<NonNullGraphType<StringGraphType>>("class");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("registry");
            Field<NonNullGraphType<StringGraphType>>("details");
        }
    }
}

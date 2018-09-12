namespace ShipServer.Model
{
    using Newtonsoft.Json.Linq;

    public class GraphQLQuery
    {
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}

namespace ShipServer.Model
{
    using System;
    using System.Collections.Generic;

    public class StarshipClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Starship> Ships { get; set; }
    }
}

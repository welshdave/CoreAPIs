namespace ShipServer.Model
{
    using System;

    public class Starship
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Registry { get; set; }
        public string Details { get; set; }
    }
}

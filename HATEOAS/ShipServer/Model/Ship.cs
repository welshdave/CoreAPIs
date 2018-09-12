namespace ShipServer.Model
{
    using System;

    public class Ship
    {
        public Guid Id => Guid.NewGuid();
        public string Class { get; set; }
        public string Name { get; set; }
        public string Registry { get; set; }
        public string Details { get; set; }
    }
}

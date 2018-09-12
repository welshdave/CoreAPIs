namespace ShipServer
{
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using LiteDB;
    using Model;
    using Newtonsoft.Json;

    public class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists(@"ships.db")) PopulateData();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        private static void PopulateData()
        {
            var json = File.ReadAllText(@"ships.json");

            var ships = JsonConvert.DeserializeObject<List<Starship>>(json);

            using (var db = new LiteDatabase(@"ships.db"))
            {
                var col = db.GetCollection<Starship>("Starships");

                col.InsertBulk(ships);
            }
        }
    }
}

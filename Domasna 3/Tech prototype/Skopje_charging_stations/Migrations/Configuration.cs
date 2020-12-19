namespace Skopje_charging_stations.Migrations
{
    using Skopje_charging_stations.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<Skopje_charging_stations.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Skopje_charging_stations.Models.ApplicationDbContext context)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\leale\\Downloads\\finalen_csv.csv");
            string line = file.ReadLine();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                charging_station scs = new charging_station();
                int id = Int32.Parse(parts[0].ToString());
                scs.id = id;
                scs.longitude = Double.Parse(parts[1]);
                scs.latitude = Double.Parse(parts[2]);
                scs.amenity = parts[3];
                scs.fee = parts[4];
                scs.openingHours = parts[5];
                scs.operatorCS = parts[6];
                scs.socket = parts[7];
                scs.tip = parts[8];
                scs.address = parts[9];
                scs.municipality = parts[10];
                
                var existsInDb = context.charging_station
                .Where(c => c.id == scs.id)
                .SingleOrDefault();
                if (existsInDb != null)
                    context.charging_station.AddOrUpdate(scs);
                else
                    context.charging_station.Add(scs);
            }
        }
    }
}

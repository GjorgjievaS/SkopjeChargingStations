using Demo.Models;
using System;
using System.Linq;

public static class DbInitialize
{
    public static void Initialize(Demo.Data.ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.Charging_station.Any())
        {
            return;
        }

        System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Blagica\\Desktop\\finalen_csv.csv");
        string line = "";
        file.ReadLine();
        while ((line = file.ReadLine()) != null)
        {
            if (line == null || line.StartsWith(" "))
                break;
            string[] parts = line.Split(',');
            Charging_station scs = new Charging_station();
           // int id = Int32.Parse(parts[0].ToString());
           // scs.id = id;
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

            context.Charging_station.Add(scs);

        }
        //_ = context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.atm ON;");
        context.SaveChanges();
    }
}
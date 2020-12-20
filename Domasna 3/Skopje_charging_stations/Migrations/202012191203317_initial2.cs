namespace Skopje_charging_stations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "markaVozilo", c => c.String());
            AddColumn("dbo.AspNetUsers", "modelVozilo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "modelVozilo");
            DropColumn("dbo.AspNetUsers", "markaVozilo");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}

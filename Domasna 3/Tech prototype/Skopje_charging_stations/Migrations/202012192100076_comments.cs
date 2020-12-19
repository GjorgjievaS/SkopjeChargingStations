namespace Skopje_charging_stations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comments : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Komentars");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Komentars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        komentar = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}

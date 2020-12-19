namespace Skopje_charging_stations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.Komentars");
        }
    }
}

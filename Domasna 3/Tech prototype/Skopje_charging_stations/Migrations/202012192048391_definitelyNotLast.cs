namespace Skopje_charging_stations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class definitelyNotLast : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        comment = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.comment);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Charging_station",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    longitude = table.Column<double>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    amenity = table.Column<string>(nullable: true),
                    fee = table.Column<string>(nullable: true),
                    openingHours = table.Column<string>(nullable: true),
                    operatorCS = table.Column<string>(nullable: true),
                    socket = table.Column<string>(nullable: true),
                    tip = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    municipality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charging_station", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Charging_station");
        }
    }
}

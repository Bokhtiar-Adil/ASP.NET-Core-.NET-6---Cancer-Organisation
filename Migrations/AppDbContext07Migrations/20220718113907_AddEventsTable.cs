using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitSiteV3.Migrations.AppDbContext07Migrations
{
    public partial class AddEventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventsTable",
                columns: table => new
                {
                    Ev_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ev_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ev_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ev_timedate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ev_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsTable", x => x.Ev_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventsTable");
        }
    }
}

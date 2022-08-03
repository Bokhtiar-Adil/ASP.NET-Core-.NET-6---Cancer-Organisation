using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitSiteV3.Migrations.AppDbContext04Migrations
{
    public partial class AddDonationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonationTable",
                columns: table => new
                {
                    Don_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Don_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Don_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Don_amount = table.Column<int>(type: "int", nullable: false),
                    Don_details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationTable", x => x.Don_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonationTable");
        }
    }
}

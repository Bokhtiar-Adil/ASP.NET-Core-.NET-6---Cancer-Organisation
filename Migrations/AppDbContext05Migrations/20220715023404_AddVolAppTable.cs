using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitSiteV3.Migrations.AppDbContext05Migrations
{
    public partial class AddVolAppTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VolAppTable",
                columns: table => new
                {
                    VA_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VA_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VA_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolAppTable", x => x.VA_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolAppTable");
        }
    }
}

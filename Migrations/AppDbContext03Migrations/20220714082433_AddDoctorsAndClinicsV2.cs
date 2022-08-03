using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitSiteV3.Migrations.AppDbContext03Migrations
{
    public partial class AddDoctorsAndClinicsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorsList2",
                columns: table => new
                {
                    Doc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doc_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doc_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doc_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doc_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doc_email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsList2", x => x.Doc_Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentCentersList2",
                columns: table => new
                {
                    TC_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC_email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentCentersList2", x => x.TC_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorsList2");

            migrationBuilder.DropTable(
                name: "TreatmentCentersList2");
        }
    }
}

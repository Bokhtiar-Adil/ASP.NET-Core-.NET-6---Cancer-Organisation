using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitSiteV3.Migrations
{
    public partial class AddHelpSupportForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodDonerTable",
                columns: table => new
                {
                    BB_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BB_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BB_father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BB_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BB_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BB_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BB_occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BB_blodtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BB_quantity = table.Column<int>(type: "int", nullable: false),
                    BB_deadline = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodDonerTable", x => x.BB_Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialAidTable",
                columns: table => new
                {
                    AID_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AID_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID_father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AID_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AID_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID_occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID_reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialAidTable", x => x.AID_Id);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerReqTable",
                columns: table => new
                {
                    VLreq_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VLreq_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VLreq_father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VLreq_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VLreq_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VLreq_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VLreq_occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VLreq_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VLreq_quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerReqTable", x => x.VLreq_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodDonerTable");

            migrationBuilder.DropTable(
                name: "FinancialAidTable");

            migrationBuilder.DropTable(
                name: "VolunteerReqTable");
        }
    }
}

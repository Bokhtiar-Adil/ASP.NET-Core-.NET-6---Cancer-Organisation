using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitSiteV3.Migrations.AppDbContext06Migrations
{
    public partial class AddRegVolTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisteredVolunteerTable",
                columns: table => new
                {
                    VReg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VReg_branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VReg_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VReg_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredVolunteerTable", x => x.VReg_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisteredVolunteerTable");
        }
    }
}

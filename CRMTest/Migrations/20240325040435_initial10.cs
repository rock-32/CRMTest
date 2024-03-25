using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "qualification_id",
                table: "LeadsTb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LeadQualification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadQualification", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_qualification_id",
                table: "LeadsTb",
                column: "qualification_id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_LeadQualification_qualification_id",
                table: "LeadsTb",
                column: "qualification_id",
                principalTable: "LeadQualification",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_LeadQualification_qualification_id",
                table: "LeadsTb");

            migrationBuilder.DropTable(
                name: "LeadQualification");

            migrationBuilder.DropIndex(
                name: "IX_LeadsTb_qualification_id",
                table: "LeadsTb");

            migrationBuilder.DropColumn(
                name: "qualification_id",
                table: "LeadsTb");
        }
    }
}

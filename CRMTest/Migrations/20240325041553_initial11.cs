using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "client_id",
                table: "LeadQualification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeadQualification_client_id",
                table: "LeadQualification",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadQualification_ClientTb_client_id",
                table: "LeadQualification",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadQualification_ClientTb_client_id",
                table: "LeadQualification");

            migrationBuilder.DropIndex(
                name: "IX_LeadQualification_client_id",
                table: "LeadQualification");

            migrationBuilder.DropColumn(
                name: "client_id",
                table: "LeadQualification");
        }
    }
}

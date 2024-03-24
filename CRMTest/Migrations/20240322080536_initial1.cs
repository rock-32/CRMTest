using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsHistory_Staffs_UpdatedBy",
                table: "LeadsHistory");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "LeadsHistory",
                newName: "updated_by");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsHistory_UpdatedBy",
                table: "LeadsHistory",
                newName: "IX_LeadsHistory_updated_by");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsHistory_Staffs_updated_by",
                table: "LeadsHistory",
                column: "updated_by",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsHistory_Staffs_updated_by",
                table: "LeadsHistory");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "LeadsHistory",
                newName: "UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsHistory_updated_by",
                table: "LeadsHistory",
                newName: "IX_LeadsHistory_UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsHistory_Staffs_UpdatedBy",
                table: "LeadsHistory",
                column: "UpdatedBy",
                principalTable: "Staffs",
                principalColumn: "Id");
        }
    }
}

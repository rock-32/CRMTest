using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "status_id",
                table: "StaffTask",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StaffTaskStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTaskStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffTask_status_id",
                table: "StaffTask",
                column: "status_id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTask_StaffTaskStatus_status_id",
                table: "StaffTask",
                column: "status_id",
                principalTable: "StaffTaskStatus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffTask_StaffTaskStatus_status_id",
                table: "StaffTask");

            migrationBuilder.DropTable(
                name: "StaffTaskStatus");

            migrationBuilder.DropIndex(
                name: "IX_StaffTask_status_id",
                table: "StaffTask");

            migrationBuilder.DropColumn(
                name: "status_id",
                table: "StaffTask");
        }
    }
}

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
            migrationBuilder.DropForeignKey(
                name: "FK_StaffRoleTb_ClientTb_client_id",
                table: "StaffRoleTb");

            migrationBuilder.DropIndex(
                name: "IX_StaffRoleTb_client_id",
                table: "StaffRoleTb");

            migrationBuilder.DropColumn(
                name: "client_id",
                table: "StaffRoleTb");

            migrationBuilder.AddColumn<int>(
                name: "clientId",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "client_id",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    leader_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTeam_StaffsTb_user_id",
                        column: x => x.user_id,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_clientId",
                table: "RolePermission",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeam_user_id",
                table: "UserTeam",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermission_ClientTb_clientId",
                table: "RolePermission",
                column: "clientId",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_ClientTb_clientId",
                table: "RolePermission");

            migrationBuilder.DropTable(
                name: "UserTeam");

            migrationBuilder.DropIndex(
                name: "IX_RolePermission_clientId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "clientId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "client_id",
                table: "RolePermission");

            migrationBuilder.AddColumn<int>(
                name: "client_id",
                table: "StaffRoleTb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StaffRoleTb_client_id",
                table: "StaffRoleTb",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffRoleTb_ClientTb_client_id",
                table: "StaffRoleTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

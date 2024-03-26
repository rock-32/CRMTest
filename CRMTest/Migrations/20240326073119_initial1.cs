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
            migrationBuilder.DropColumn(
                name: "Name",
                table: "StaffsTb");

            migrationBuilder.AddColumn<int>(
                name: "userinfo_id",
                table: "StaffsTb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LeadDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lead_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadDocuments_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    permission_id = table.Column<int>(type: "int", nullable: false),
                    CanView = table.Column<bool>(type: "bit", nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false),
                    CanAdd = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permissions_permission_id",
                        column: x => x.permission_id,
                        principalTable: "Permissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermission_StaffRoleTb_role_id",
                        column: x => x.role_id,
                        principalTable: "StaffRoleTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffsTb_userinfo_id",
                table: "StaffsTb",
                column: "userinfo_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadDocuments_lead_id",
                table: "LeadDocuments",
                column: "lead_id");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_permission_id",
                table: "RolePermission",
                column: "permission_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_role_id",
                table: "RolePermission",
                column: "role_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffsTb_UserInfo_userinfo_id",
                table: "StaffsTb",
                column: "userinfo_id",
                principalTable: "UserInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffsTb_UserInfo_userinfo_id",
                table: "StaffsTb");

            migrationBuilder.DropTable(
                name: "LeadDocuments");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_StaffsTb_userinfo_id",
                table: "StaffsTb");

            migrationBuilder.DropColumn(
                name: "userinfo_id",
                table: "StaffsTb");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StaffsTb",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

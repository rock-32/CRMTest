using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TasksHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stafftask_id = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: false),
                    staffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksHistory_StaffTaskTb_stafftask_id",
                        column: x => x.stafftask_id,
                        principalTable: "StaffTaskTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TasksHistory_StaffsTb_staffId",
                        column: x => x.staffId,
                        principalTable: "StaffsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TasksHistory_staffId",
                table: "TasksHistory",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksHistory_stafftask_id",
                table: "TasksHistory",
                column: "stafftask_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TasksHistory");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_StaffsTb_CreatedBy",
                table: "LeadsTb");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "LeadsTb",
                newName: "updated_by");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_CreatedBy",
                table: "LeadsTb",
                newName: "IX_LeadsTb_updated_by");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TasksTb",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "TasksTb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "LeadsTb",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "LeadsTb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LeadCallHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lead_id = table.Column<int>(type: "int", nullable: false),
                    agent_id = table.Column<int>(type: "int", nullable: false),
                    CallDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordedFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCallHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadCallHistory_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadCallHistory_StaffsTb_agent_id",
                        column: x => x.agent_id,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TasksTb_created_by",
                table: "TasksTb",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCallHistory_agent_id",
                table: "LeadCallHistory",
                column: "agent_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCallHistory_lead_id",
                table: "LeadCallHistory",
                column: "lead_id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_StaffsTb_updated_by",
                table: "LeadsTb",
                column: "updated_by",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksTb_StaffsTb_created_by",
                table: "TasksTb",
                column: "created_by",
                principalTable: "StaffsTb",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_StaffsTb_updated_by",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksTb_StaffsTb_created_by",
                table: "TasksTb");

            migrationBuilder.DropTable(
                name: "LeadCallHistory");

            migrationBuilder.DropIndex(
                name: "IX_TasksTb_created_by",
                table: "TasksTb");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TasksTb");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "TasksTb");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "LeadsTb");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "LeadsTb");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "LeadsTb",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_updated_by",
                table: "LeadsTb",
                newName: "IX_LeadsTb_CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_StaffsTb_CreatedBy",
                table: "LeadsTb",
                column: "CreatedBy",
                principalTable: "StaffsTb",
                principalColumn: "Id");
        }
    }
}

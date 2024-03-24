using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    source_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    agent_id = table.Column<int>(type: "int", nullable: false),
                    campaign_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientCustomers_CampaignTb_campaign_id",
                        column: x => x.campaign_id,
                        principalTable: "CampaignTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientCustomers_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCustomers_LeadSource_source_id",
                        column: x => x.source_id,
                        principalTable: "LeadSource",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientCustomers_Staffs_agent_id",
                        column: x => x.agent_id,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomers_agent_id",
                table: "ClientCustomers",
                column: "agent_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomers_campaign_id",
                table: "ClientCustomers",
                column: "campaign_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomers_client_id",
                table: "ClientCustomers",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomers_source_id",
                table: "ClientCustomers",
                column: "source_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCustomers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmAdminsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmAdminsTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staffs_StaffRole_role_id",
                        column: x => x.role_id,
                        principalTable: "StaffRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignTb_Staffs_created_by",
                        column: x => x.created_by,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    task_id = table.Column<int>(type: "int", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffTask_Staffs_staff_id",
                        column: x => x.staff_id,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffTask_Tasks_task_id",
                        column: x => x.task_id,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
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
                    NextFollowUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowUpNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    source_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    campaign_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leads_CampaignTb_campaign_id",
                        column: x => x.campaign_id,
                        principalTable: "CampaignTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leads_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leads_LeadSource_source_id",
                        column: x => x.source_id,
                        principalTable: "LeadSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leads_LeadStatus_status_id",
                        column: x => x.status_id,
                        principalTable: "LeadStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leads_Staffs_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadsHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    lead_id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadsHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadsHistory_Leads_lead_id",
                        column: x => x.lead_id,
                        principalTable: "Leads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsHistory_Staffs_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTb_client_id",
                table: "CampaignTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTb_created_by",
                table: "CampaignTb",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_campaign_id",
                table: "Leads",
                column: "campaign_id");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_client_id",
                table: "Leads",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_CreatedBy",
                table: "Leads",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_source_id",
                table: "Leads",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_status_id",
                table: "Leads",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsHistory_lead_id",
                table: "LeadsHistory",
                column: "lead_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsHistory_UpdatedBy",
                table: "LeadsHistory",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_client_id",
                table: "Staffs",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_role_id",
                table: "Staffs",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTask_staff_id",
                table: "StaffTask",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTask_task_id",
                table: "StaffTask",
                column: "task_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrmAdminsTb");

            migrationBuilder.DropTable(
                name: "LeadsHistory");

            migrationBuilder.DropTable(
                name: "StaffTask");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "CampaignTb");

            migrationBuilder.DropTable(
                name: "LeadSource");

            migrationBuilder.DropTable(
                name: "LeadStatus");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "ClientTb");

            migrationBuilder.DropTable(
                name: "StaffRole");
        }
    }
}

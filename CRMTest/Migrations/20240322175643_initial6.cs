using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignTb_Staffs_created_by",
                table: "CampaignTb");

            migrationBuilder.DropForeignKey(
                name: "FK_clientCustomersTb_CampaignTb_campaign_id",
                table: "clientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_clientCustomersTb_ClientTb_client_id",
                table: "clientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_clientCustomersTb_LeadSource_source_id",
                table: "clientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_clientCustomersTb_Staffs_agent_id",
                table: "clientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_CampaignTb_campaign_id",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_ClientTb_client_id",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_LeadSource_source_id",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_LeadStatus_status_id",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Staffs_CreatedBy",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsHistory_Leads_lead_id",
                table: "LeadsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsHistory_Staffs_updated_by",
                table: "LeadsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_ClientTb_client_id",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_StaffRole_role_id",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTask_Staffs_staff_id",
                table: "StaffTask");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTask_Tasks_task_id",
                table: "StaffTask");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTask_staffTaskStatusTb_status_id",
                table: "StaffTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staffTaskStatusTb",
                table: "staffTaskStatusTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientCustomersTb",
                table: "clientCustomersTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffTask",
                table: "StaffTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffRole",
                table: "StaffRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadStatus",
                table: "LeadStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadSource",
                table: "LeadSource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadsHistory",
                table: "LeadsHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leads",
                table: "Leads");

            migrationBuilder.RenameTable(
                name: "staffTaskStatusTb",
                newName: "StaffTaskStatusTb");

            migrationBuilder.RenameTable(
                name: "clientCustomersTb",
                newName: "ClientCustomersTb");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "TasksTb");

            migrationBuilder.RenameTable(
                name: "StaffTask",
                newName: "StaffTaskTb");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "StaffsTb");

            migrationBuilder.RenameTable(
                name: "StaffRole",
                newName: "StaffRoleTb");

            migrationBuilder.RenameTable(
                name: "LeadStatus",
                newName: "LeadStatusTb");

            migrationBuilder.RenameTable(
                name: "LeadSource",
                newName: "LeadSourceTb");

            migrationBuilder.RenameTable(
                name: "LeadsHistory",
                newName: "LeadsHistoryTb");

            migrationBuilder.RenameTable(
                name: "Leads",
                newName: "LeadsTb");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_source_id",
                table: "ClientCustomersTb",
                newName: "IX_ClientCustomersTb_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_client_id",
                table: "ClientCustomersTb",
                newName: "IX_ClientCustomersTb_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_campaign_id",
                table: "ClientCustomersTb",
                newName: "IX_ClientCustomersTb_campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_agent_id",
                table: "ClientCustomersTb",
                newName: "IX_ClientCustomersTb_agent_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffTask_task_id",
                table: "StaffTaskTb",
                newName: "IX_StaffTaskTb_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffTask_status_id",
                table: "StaffTaskTb",
                newName: "IX_StaffTaskTb_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffTask_staff_id",
                table: "StaffTaskTb",
                newName: "IX_StaffTaskTb_staff_id");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_role_id",
                table: "StaffsTb",
                newName: "IX_StaffsTb_role_id");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_client_id",
                table: "StaffsTb",
                newName: "IX_StaffsTb_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsHistory_updated_by",
                table: "LeadsHistoryTb",
                newName: "IX_LeadsHistoryTb_updated_by");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsHistory_lead_id",
                table: "LeadsHistoryTb",
                newName: "IX_LeadsHistoryTb_lead_id");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_status_id",
                table: "LeadsTb",
                newName: "IX_LeadsTb_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_source_id",
                table: "LeadsTb",
                newName: "IX_LeadsTb_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_CreatedBy",
                table: "LeadsTb",
                newName: "IX_LeadsTb_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_client_id",
                table: "LeadsTb",
                newName: "IX_LeadsTb_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_campaign_id",
                table: "LeadsTb",
                newName: "IX_LeadsTb_campaign_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffTaskStatusTb",
                table: "StaffTaskStatusTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientCustomersTb",
                table: "ClientCustomersTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasksTb",
                table: "TasksTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffTaskTb",
                table: "StaffTaskTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffsTb",
                table: "StaffsTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffRoleTb",
                table: "StaffRoleTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadStatusTb",
                table: "LeadStatusTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadSourceTb",
                table: "LeadSourceTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadsHistoryTb",
                table: "LeadsHistoryTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadsTb",
                table: "LeadsTb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignTb_StaffsTb_created_by",
                table: "CampaignTb",
                column: "created_by",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomersTb_CampaignTb_campaign_id",
                table: "ClientCustomersTb",
                column: "campaign_id",
                principalTable: "CampaignTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomersTb_ClientTb_client_id",
                table: "ClientCustomersTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomersTb_LeadSourceTb_source_id",
                table: "ClientCustomersTb",
                column: "source_id",
                principalTable: "LeadSourceTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomersTb_StaffsTb_agent_id",
                table: "ClientCustomersTb",
                column: "agent_id",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsHistoryTb_LeadsTb_lead_id",
                table: "LeadsHistoryTb",
                column: "lead_id",
                principalTable: "LeadsTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsHistoryTb_StaffsTb_updated_by",
                table: "LeadsHistoryTb",
                column: "updated_by",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_CampaignTb_campaign_id",
                table: "LeadsTb",
                column: "campaign_id",
                principalTable: "CampaignTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_ClientTb_client_id",
                table: "LeadsTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_LeadSourceTb_source_id",
                table: "LeadsTb",
                column: "source_id",
                principalTable: "LeadSourceTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_LeadStatusTb_status_id",
                table: "LeadsTb",
                column: "status_id",
                principalTable: "LeadStatusTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_StaffsTb_CreatedBy",
                table: "LeadsTb",
                column: "CreatedBy",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffsTb_ClientTb_client_id",
                table: "StaffsTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffsTb_StaffRoleTb_role_id",
                table: "StaffsTb",
                column: "role_id",
                principalTable: "StaffRoleTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTaskTb_StaffTaskStatusTb_status_id",
                table: "StaffTaskTb",
                column: "status_id",
                principalTable: "StaffTaskStatusTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTaskTb_StaffsTb_staff_id",
                table: "StaffTaskTb",
                column: "staff_id",
                principalTable: "StaffsTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTaskTb_TasksTb_task_id",
                table: "StaffTaskTb",
                column: "task_id",
                principalTable: "TasksTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignTb_StaffsTb_created_by",
                table: "CampaignTb");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomersTb_CampaignTb_campaign_id",
                table: "ClientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomersTb_ClientTb_client_id",
                table: "ClientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomersTb_LeadSourceTb_source_id",
                table: "ClientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomersTb_StaffsTb_agent_id",
                table: "ClientCustomersTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsHistoryTb_LeadsTb_lead_id",
                table: "LeadsHistoryTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsHistoryTb_StaffsTb_updated_by",
                table: "LeadsHistoryTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_CampaignTb_campaign_id",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_ClientTb_client_id",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_LeadSourceTb_source_id",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_LeadStatusTb_status_id",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_StaffsTb_CreatedBy",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffsTb_ClientTb_client_id",
                table: "StaffsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffsTb_StaffRoleTb_role_id",
                table: "StaffsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTaskTb_StaffTaskStatusTb_status_id",
                table: "StaffTaskTb");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTaskTb_StaffsTb_staff_id",
                table: "StaffTaskTb");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTaskTb_TasksTb_task_id",
                table: "StaffTaskTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffTaskStatusTb",
                table: "StaffTaskStatusTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientCustomersTb",
                table: "ClientCustomersTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TasksTb",
                table: "TasksTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffTaskTb",
                table: "StaffTaskTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffsTb",
                table: "StaffsTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffRoleTb",
                table: "StaffRoleTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadsTb",
                table: "LeadsTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadStatusTb",
                table: "LeadStatusTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadSourceTb",
                table: "LeadSourceTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadsHistoryTb",
                table: "LeadsHistoryTb");

            migrationBuilder.RenameTable(
                name: "StaffTaskStatusTb",
                newName: "staffTaskStatusTb");

            migrationBuilder.RenameTable(
                name: "ClientCustomersTb",
                newName: "clientCustomersTb");

            migrationBuilder.RenameTable(
                name: "TasksTb",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "StaffTaskTb",
                newName: "StaffTask");

            migrationBuilder.RenameTable(
                name: "StaffsTb",
                newName: "Staffs");

            migrationBuilder.RenameTable(
                name: "StaffRoleTb",
                newName: "StaffRole");

            migrationBuilder.RenameTable(
                name: "LeadsTb",
                newName: "Leads");

            migrationBuilder.RenameTable(
                name: "LeadStatusTb",
                newName: "LeadStatus");

            migrationBuilder.RenameTable(
                name: "LeadSourceTb",
                newName: "LeadSource");

            migrationBuilder.RenameTable(
                name: "LeadsHistoryTb",
                newName: "LeadsHistory");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomersTb_source_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomersTb_client_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomersTb_campaign_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomersTb_agent_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_agent_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffTaskTb_task_id",
                table: "StaffTask",
                newName: "IX_StaffTask_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffTaskTb_status_id",
                table: "StaffTask",
                newName: "IX_StaffTask_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffTaskTb_staff_id",
                table: "StaffTask",
                newName: "IX_StaffTask_staff_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffsTb_role_id",
                table: "Staffs",
                newName: "IX_Staffs_role_id");

            migrationBuilder.RenameIndex(
                name: "IX_StaffsTb_client_id",
                table: "Staffs",
                newName: "IX_Staffs_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_status_id",
                table: "Leads",
                newName: "IX_Leads_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_source_id",
                table: "Leads",
                newName: "IX_Leads_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_CreatedBy",
                table: "Leads",
                newName: "IX_Leads_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_client_id",
                table: "Leads",
                newName: "IX_Leads_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsTb_campaign_id",
                table: "Leads",
                newName: "IX_Leads_campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsHistoryTb_updated_by",
                table: "LeadsHistory",
                newName: "IX_LeadsHistory_updated_by");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsHistoryTb_lead_id",
                table: "LeadsHistory",
                newName: "IX_LeadsHistory_lead_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffTaskStatusTb",
                table: "staffTaskStatusTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientCustomersTb",
                table: "clientCustomersTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffTask",
                table: "StaffTask",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffRole",
                table: "StaffRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leads",
                table: "Leads",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadStatus",
                table: "LeadStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadSource",
                table: "LeadSource",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadsHistory",
                table: "LeadsHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignTb_Staffs_created_by",
                table: "CampaignTb",
                column: "created_by",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientCustomersTb_CampaignTb_campaign_id",
                table: "clientCustomersTb",
                column: "campaign_id",
                principalTable: "CampaignTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientCustomersTb_ClientTb_client_id",
                table: "clientCustomersTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clientCustomersTb_LeadSource_source_id",
                table: "clientCustomersTb",
                column: "source_id",
                principalTable: "LeadSource",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientCustomersTb_Staffs_agent_id",
                table: "clientCustomersTb",
                column: "agent_id",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_CampaignTb_campaign_id",
                table: "Leads",
                column: "campaign_id",
                principalTable: "CampaignTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_ClientTb_client_id",
                table: "Leads",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_LeadSource_source_id",
                table: "Leads",
                column: "source_id",
                principalTable: "LeadSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_LeadStatus_status_id",
                table: "Leads",
                column: "status_id",
                principalTable: "LeadStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Staffs_CreatedBy",
                table: "Leads",
                column: "CreatedBy",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsHistory_Leads_lead_id",
                table: "LeadsHistory",
                column: "lead_id",
                principalTable: "Leads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsHistory_Staffs_updated_by",
                table: "LeadsHistory",
                column: "updated_by",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_ClientTb_client_id",
                table: "Staffs",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_StaffRole_role_id",
                table: "Staffs",
                column: "role_id",
                principalTable: "StaffRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTask_Staffs_staff_id",
                table: "StaffTask",
                column: "staff_id",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTask_Tasks_task_id",
                table: "StaffTask",
                column: "task_id",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTask_staffTaskStatusTb_status_id",
                table: "StaffTask",
                column: "status_id",
                principalTable: "staffTaskStatusTb",
                principalColumn: "Id");
        }
    }
}

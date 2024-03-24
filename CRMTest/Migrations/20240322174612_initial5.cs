using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomers_CampaignTb_campaign_id",
                table: "ClientCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomers_ClientTb_client_id",
                table: "ClientCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomers_LeadSource_source_id",
                table: "ClientCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCustomers_Staffs_agent_id",
                table: "ClientCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffTask_StaffTaskStatus_status_id",
                table: "StaffTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffTaskStatus",
                table: "StaffTaskStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientCustomers",
                table: "ClientCustomers");

            migrationBuilder.RenameTable(
                name: "StaffTaskStatus",
                newName: "staffTaskStatusTb");

            migrationBuilder.RenameTable(
                name: "ClientCustomers",
                newName: "clientCustomersTb");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomers_source_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomers_client_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomers_campaign_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCustomers_agent_id",
                table: "clientCustomersTb",
                newName: "IX_clientCustomersTb_agent_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffTaskStatusTb",
                table: "staffTaskStatusTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientCustomersTb",
                table: "clientCustomersTb",
                column: "Id");

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
                name: "FK_StaffTask_staffTaskStatusTb_status_id",
                table: "StaffTask",
                column: "status_id",
                principalTable: "staffTaskStatusTb",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_StaffTask_staffTaskStatusTb_status_id",
                table: "StaffTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staffTaskStatusTb",
                table: "staffTaskStatusTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientCustomersTb",
                table: "clientCustomersTb");

            migrationBuilder.RenameTable(
                name: "staffTaskStatusTb",
                newName: "StaffTaskStatus");

            migrationBuilder.RenameTable(
                name: "clientCustomersTb",
                newName: "ClientCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_source_id",
                table: "ClientCustomers",
                newName: "IX_ClientCustomers_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_client_id",
                table: "ClientCustomers",
                newName: "IX_ClientCustomers_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_campaign_id",
                table: "ClientCustomers",
                newName: "IX_ClientCustomers_campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_clientCustomersTb_agent_id",
                table: "ClientCustomers",
                newName: "IX_ClientCustomers_agent_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffTaskStatus",
                table: "StaffTaskStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientCustomers",
                table: "ClientCustomers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomers_CampaignTb_campaign_id",
                table: "ClientCustomers",
                column: "campaign_id",
                principalTable: "CampaignTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomers_ClientTb_client_id",
                table: "ClientCustomers",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomers_LeadSource_source_id",
                table: "ClientCustomers",
                column: "source_id",
                principalTable: "LeadSource",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCustomers_Staffs_agent_id",
                table: "ClientCustomers",
                column: "agent_id",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffTask_StaffTaskStatus_status_id",
                table: "StaffTask",
                column: "status_id",
                principalTable: "StaffTaskStatus",
                principalColumn: "Id");
        }
    }
}

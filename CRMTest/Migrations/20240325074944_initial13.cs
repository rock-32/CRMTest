using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMTest.Migrations
{
    /// <inheritdoc />
    public partial class initial13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFeedback_ClientTb_client_id",
                table: "ClientFeedback");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadCallHistory_LeadsTb_lead_id",
                table: "LeadCallHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadCallHistory_StaffsTb_agent_id",
                table: "LeadCallHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadQualification_ClientTb_client_id",
                table: "LeadQualification");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_LeadQualification_qualification_id",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksHistory_StaffTaskTb_stafftask_id",
                table: "TasksHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksHistory_StaffsTb_staffId",
                table: "TasksHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TasksHistory",
                table: "TasksHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadQualification",
                table: "LeadQualification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadCallHistory",
                table: "LeadCallHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientFeedback",
                table: "ClientFeedback");

            migrationBuilder.RenameTable(
                name: "TasksHistory",
                newName: "TasksHistoryTb");

            migrationBuilder.RenameTable(
                name: "LeadQualification",
                newName: "LeadQualificationTb");

            migrationBuilder.RenameTable(
                name: "LeadCallHistory",
                newName: "LeadCallHistoryTb");

            migrationBuilder.RenameTable(
                name: "ClientFeedback",
                newName: "ClientFeedbackTb");

            migrationBuilder.RenameIndex(
                name: "IX_TasksHistory_stafftask_id",
                table: "TasksHistoryTb",
                newName: "IX_TasksHistoryTb_stafftask_id");

            migrationBuilder.RenameIndex(
                name: "IX_TasksHistory_staffId",
                table: "TasksHistoryTb",
                newName: "IX_TasksHistoryTb_staffId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadQualification_client_id",
                table: "LeadQualificationTb",
                newName: "IX_LeadQualificationTb_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCallHistory_lead_id",
                table: "LeadCallHistoryTb",
                newName: "IX_LeadCallHistoryTb_lead_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCallHistory_agent_id",
                table: "LeadCallHistoryTb",
                newName: "IX_LeadCallHistoryTb_agent_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientFeedback_client_id",
                table: "ClientFeedbackTb",
                newName: "IX_ClientFeedbackTb_client_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasksHistoryTb",
                table: "TasksHistoryTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadQualificationTb",
                table: "LeadQualificationTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadCallHistoryTb",
                table: "LeadCallHistoryTb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientFeedbackTb",
                table: "ClientFeedbackTb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFeedbackTb_ClientTb_client_id",
                table: "ClientFeedbackTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCallHistoryTb_LeadsTb_lead_id",
                table: "LeadCallHistoryTb",
                column: "lead_id",
                principalTable: "LeadsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCallHistoryTb_StaffsTb_agent_id",
                table: "LeadCallHistoryTb",
                column: "agent_id",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadQualificationTb_ClientTb_client_id",
                table: "LeadQualificationTb",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_LeadQualificationTb_qualification_id",
                table: "LeadsTb",
                column: "qualification_id",
                principalTable: "LeadQualificationTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksHistoryTb_StaffTaskTb_stafftask_id",
                table: "TasksHistoryTb",
                column: "stafftask_id",
                principalTable: "StaffTaskTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksHistoryTb_StaffsTb_staffId",
                table: "TasksHistoryTb",
                column: "staffId",
                principalTable: "StaffsTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFeedbackTb_ClientTb_client_id",
                table: "ClientFeedbackTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadCallHistoryTb_LeadsTb_lead_id",
                table: "LeadCallHistoryTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadCallHistoryTb_StaffsTb_agent_id",
                table: "LeadCallHistoryTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadQualificationTb_ClientTb_client_id",
                table: "LeadQualificationTb");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsTb_LeadQualificationTb_qualification_id",
                table: "LeadsTb");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksHistoryTb_StaffTaskTb_stafftask_id",
                table: "TasksHistoryTb");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksHistoryTb_StaffsTb_staffId",
                table: "TasksHistoryTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TasksHistoryTb",
                table: "TasksHistoryTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadQualificationTb",
                table: "LeadQualificationTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadCallHistoryTb",
                table: "LeadCallHistoryTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientFeedbackTb",
                table: "ClientFeedbackTb");

            migrationBuilder.RenameTable(
                name: "TasksHistoryTb",
                newName: "TasksHistory");

            migrationBuilder.RenameTable(
                name: "LeadQualificationTb",
                newName: "LeadQualification");

            migrationBuilder.RenameTable(
                name: "LeadCallHistoryTb",
                newName: "LeadCallHistory");

            migrationBuilder.RenameTable(
                name: "ClientFeedbackTb",
                newName: "ClientFeedback");

            migrationBuilder.RenameIndex(
                name: "IX_TasksHistoryTb_stafftask_id",
                table: "TasksHistory",
                newName: "IX_TasksHistory_stafftask_id");

            migrationBuilder.RenameIndex(
                name: "IX_TasksHistoryTb_staffId",
                table: "TasksHistory",
                newName: "IX_TasksHistory_staffId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadQualificationTb_client_id",
                table: "LeadQualification",
                newName: "IX_LeadQualification_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCallHistoryTb_lead_id",
                table: "LeadCallHistory",
                newName: "IX_LeadCallHistory_lead_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadCallHistoryTb_agent_id",
                table: "LeadCallHistory",
                newName: "IX_LeadCallHistory_agent_id");

            migrationBuilder.RenameIndex(
                name: "IX_ClientFeedbackTb_client_id",
                table: "ClientFeedback",
                newName: "IX_ClientFeedback_client_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasksHistory",
                table: "TasksHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadQualification",
                table: "LeadQualification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadCallHistory",
                table: "LeadCallHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientFeedback",
                table: "ClientFeedback",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFeedback_ClientTb_client_id",
                table: "ClientFeedback",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCallHistory_LeadsTb_lead_id",
                table: "LeadCallHistory",
                column: "lead_id",
                principalTable: "LeadsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadCallHistory_StaffsTb_agent_id",
                table: "LeadCallHistory",
                column: "agent_id",
                principalTable: "StaffsTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadQualification_ClientTb_client_id",
                table: "LeadQualification",
                column: "client_id",
                principalTable: "ClientTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsTb_LeadQualification_qualification_id",
                table: "LeadsTb",
                column: "qualification_id",
                principalTable: "LeadQualification",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksHistory_StaffTaskTb_stafftask_id",
                table: "TasksHistory",
                column: "stafftask_id",
                principalTable: "StaffTaskTb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksHistory_StaffsTb_staffId",
                table: "TasksHistory",
                column: "staffId",
                principalTable: "StaffsTb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

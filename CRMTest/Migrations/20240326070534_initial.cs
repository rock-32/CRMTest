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
                name: "ClientAccountInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyWebSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GST_IN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccountInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientAddressInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAddressInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientBillingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientBillingInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrmAdminsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmAdminsTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStatusTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStatusTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffTaskStatusTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTaskStatusTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Validity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientSubscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    current_subscription = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidUpTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientSubscription_SubscriptionStatus_status_id",
                        column: x => x.status_id,
                        principalTable: "SubscriptionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientSubscription_Subscription_current_subscription",
                        column: x => x.current_subscription,
                        principalTable: "Subscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accountinfo_id = table.Column<int>(type: "int", nullable: false),
                    billingInfo_id = table.Column<int>(type: "int", nullable: false),
                    addressInfo_id = table.Column<int>(type: "int", nullable: false),
                    subscription_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientTb_ClientAccountInfo_Accountinfo_id",
                        column: x => x.Accountinfo_id,
                        principalTable: "ClientAccountInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTb_ClientAddressInfo_addressInfo_id",
                        column: x => x.addressInfo_id,
                        principalTable: "ClientAddressInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTb_ClientBillingInfo_billingInfo_id",
                        column: x => x.billingInfo_id,
                        principalTable: "ClientBillingInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTb_ClientSubscription_subscription_id",
                        column: x => x.subscription_id,
                        principalTable: "ClientSubscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientFeedbackTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFeedbackTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientFeedbackTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    clientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomFields_ClientTb_clientId",
                        column: x => x.clientId,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadQualificationTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadQualificationTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadQualificationTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadSourceTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSourceTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadSourceTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffRoleTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRoleTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffRoleTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffsTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffsTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StaffsTb_StaffRoleTb_role_id",
                        column: x => x.role_id,
                        principalTable: "StaffRoleTb",
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
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    source_id = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_CampaignTb_LeadSourceTb_source_id",
                        column: x => x.source_id,
                        principalTable: "LeadSourceTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CampaignTb_StaffsTb_created_by",
                        column: x => x.created_by,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TasksTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksTb_StaffsTb_created_by",
                        column: x => x.created_by,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientCustomersTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    source_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    agent_id = table.Column<int>(type: "int", nullable: false),
                    campaign_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCustomersTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientCustomersTb_CampaignTb_campaign_id",
                        column: x => x.campaign_id,
                        principalTable: "CampaignTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientCustomersTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCustomersTb_LeadSourceTb_source_id",
                        column: x => x.source_id,
                        principalTable: "LeadSourceTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientCustomersTb_StaffsTb_agent_id",
                        column: x => x.agent_id,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: false),
                    source_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    NextFollowUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowUpNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qualification_id = table.Column<int>(type: "int", nullable: false),
                    ChanceOfWon = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadsTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadsTb_CampaignTb_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "CampaignTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_ClientTb_client_id",
                        column: x => x.client_id,
                        principalTable: "ClientTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_LeadQualificationTb_qualification_id",
                        column: x => x.qualification_id,
                        principalTable: "LeadQualificationTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_LeadSourceTb_source_id",
                        column: x => x.source_id,
                        principalTable: "LeadSourceTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsTb_LeadStatusTb_status_id",
                        column: x => x.status_id,
                        principalTable: "LeadStatusTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsTb_StaffsTb_updated_by",
                        column: x => x.updated_by,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffTaskTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    task_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTaskTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffTaskTb_StaffTaskStatusTb_status_id",
                        column: x => x.status_id,
                        principalTable: "StaffTaskStatusTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StaffTaskTb_StaffsTb_user_id",
                        column: x => x.user_id,
                        principalTable: "StaffsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffTaskTb_TasksTb_task_id",
                        column: x => x.task_id,
                        principalTable: "TasksTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadCallHistoryTb",
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
                    table.PrimaryKey("PK_LeadCallHistoryTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadCallHistoryTb_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadCallHistoryTb_StaffsTb_agent_id",
                        column: x => x.agent_id,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadCampaign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lead_id = table.Column<int>(type: "int", nullable: false),
                    campaign_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCampaign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadCampaign_CampaignTb_campaign_id",
                        column: x => x.campaign_id,
                        principalTable: "CampaignTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadCampaign_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadFollowUp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NextFollowUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowUpNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: false),
                    lead_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadFollowUp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadFollowUp_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadFollowUp_StaffsTb_updated_by",
                        column: x => x.updated_by,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadsHistoryTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: false),
                    lead_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadsHistoryTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadsHistoryTb_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsHistoryTb_StaffsTb_updated_by",
                        column: x => x.updated_by,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadSource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lead_id = table.Column<int>(type: "int", nullable: false),
                    source_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadSource_LeadSourceTb_source_id",
                        column: x => x.source_id,
                        principalTable: "LeadSourceTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadSource_LeadsTb_lead_id",
                        column: x => x.lead_id,
                        principalTable: "LeadsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TasksHistoryTb",
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
                    table.PrimaryKey("PK_TasksHistoryTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksHistoryTb_StaffTaskTb_stafftask_id",
                        column: x => x.stafftask_id,
                        principalTable: "StaffTaskTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TasksHistoryTb_StaffsTb_staffId",
                        column: x => x.staffId,
                        principalTable: "StaffsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_CampaignTb_source_id",
                table: "CampaignTb",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomersTb_agent_id",
                table: "ClientCustomersTb",
                column: "agent_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomersTb_campaign_id",
                table: "ClientCustomersTb",
                column: "campaign_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomersTb_client_id",
                table: "ClientCustomersTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomersTb_source_id",
                table: "ClientCustomersTb",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFeedbackTb_client_id",
                table: "ClientFeedbackTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSubscription_current_subscription",
                table: "ClientSubscription",
                column: "current_subscription");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSubscription_status_id",
                table: "ClientSubscription",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTb_Accountinfo_id",
                table: "ClientTb",
                column: "Accountinfo_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientTb_addressInfo_id",
                table: "ClientTb",
                column: "addressInfo_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientTb_billingInfo_id",
                table: "ClientTb",
                column: "billingInfo_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientTb_subscription_id",
                table: "ClientTb",
                column: "subscription_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomFields_clientId",
                table: "CustomFields",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCallHistoryTb_agent_id",
                table: "LeadCallHistoryTb",
                column: "agent_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCallHistoryTb_lead_id",
                table: "LeadCallHistoryTb",
                column: "lead_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCampaign_campaign_id",
                table: "LeadCampaign",
                column: "campaign_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadCampaign_lead_id",
                table: "LeadCampaign",
                column: "lead_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadFollowUp_lead_id",
                table: "LeadFollowUp",
                column: "lead_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadFollowUp_updated_by",
                table: "LeadFollowUp",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_LeadQualificationTb_client_id",
                table: "LeadQualificationTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsHistoryTb_lead_id",
                table: "LeadsHistoryTb",
                column: "lead_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsHistoryTb_updated_by",
                table: "LeadsHistoryTb",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_LeadSource_lead_id",
                table: "LeadSource",
                column: "lead_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadSource_source_id",
                table: "LeadSource",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadSourceTb_client_id",
                table: "LeadSourceTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_CampaignId",
                table: "LeadsTb",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_client_id",
                table: "LeadsTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_qualification_id",
                table: "LeadsTb",
                column: "qualification_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_source_id",
                table: "LeadsTb",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_status_id",
                table: "LeadsTb",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_updated_by",
                table: "LeadsTb",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_StaffRoleTb_client_id",
                table: "StaffRoleTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffsTb_client_id",
                table: "StaffsTb",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffsTb_role_id",
                table: "StaffsTb",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTaskTb_status_id",
                table: "StaffTaskTb",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTaskTb_task_id",
                table: "StaffTaskTb",
                column: "task_id");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTaskTb_user_id",
                table: "StaffTaskTb",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_TasksHistoryTb_staffId",
                table: "TasksHistoryTb",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksHistoryTb_stafftask_id",
                table: "TasksHistoryTb",
                column: "stafftask_id");

            migrationBuilder.CreateIndex(
                name: "IX_TasksTb_created_by",
                table: "TasksTb",
                column: "created_by");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCustomersTb");

            migrationBuilder.DropTable(
                name: "ClientFeedbackTb");

            migrationBuilder.DropTable(
                name: "CrmAdminsTb");

            migrationBuilder.DropTable(
                name: "CustomFields");

            migrationBuilder.DropTable(
                name: "LeadCallHistoryTb");

            migrationBuilder.DropTable(
                name: "LeadCampaign");

            migrationBuilder.DropTable(
                name: "LeadFollowUp");

            migrationBuilder.DropTable(
                name: "LeadsHistoryTb");

            migrationBuilder.DropTable(
                name: "LeadSource");

            migrationBuilder.DropTable(
                name: "TasksHistoryTb");

            migrationBuilder.DropTable(
                name: "LeadsTb");

            migrationBuilder.DropTable(
                name: "StaffTaskTb");

            migrationBuilder.DropTable(
                name: "CampaignTb");

            migrationBuilder.DropTable(
                name: "LeadQualificationTb");

            migrationBuilder.DropTable(
                name: "LeadStatusTb");

            migrationBuilder.DropTable(
                name: "StaffTaskStatusTb");

            migrationBuilder.DropTable(
                name: "TasksTb");

            migrationBuilder.DropTable(
                name: "LeadSourceTb");

            migrationBuilder.DropTable(
                name: "StaffsTb");

            migrationBuilder.DropTable(
                name: "StaffRoleTb");

            migrationBuilder.DropTable(
                name: "ClientTb");

            migrationBuilder.DropTable(
                name: "ClientAccountInfo");

            migrationBuilder.DropTable(
                name: "ClientAddressInfo");

            migrationBuilder.DropTable(
                name: "ClientBillingInfo");

            migrationBuilder.DropTable(
                name: "ClientSubscription");

            migrationBuilder.DropTable(
                name: "SubscriptionStatus");

            migrationBuilder.DropTable(
                name: "Subscription");
        }
    }
}

﻿// <auto-generated />
using System;
using CRMTest.CRMContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRMTest.Migrations
{
    [DbContext(typeof(crmContext))]
    [Migration("20240325041553_initial11")]
    partial class initial11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRMTest.Model.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CampaignTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("client_id");

                    b.HasIndex("created_by");

                    b.ToTable("CampaignTb");
                });

            modelBuilder.Entity("CRMTest.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientTb");
                });

            modelBuilder.Entity("CRMTest.Model.ClientCustomers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("agent_id")
                        .HasColumnType("int");

                    b.Property<int>("campaign_id")
                        .HasColumnType("int");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<int>("source_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("agent_id");

                    b.HasIndex("campaign_id");

                    b.HasIndex("client_id");

                    b.HasIndex("source_id");

                    b.ToTable("ClientCustomersTb");
                });

            modelBuilder.Entity("CRMTest.Model.CrmAdmins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CrmAdminsTb");
                });

            modelBuilder.Entity("CRMTest.Model.LeadCallHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CallDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RecordedFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("agent_id")
                        .HasColumnType("int");

                    b.Property<int>("lead_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("agent_id");

                    b.HasIndex("lead_id");

                    b.ToTable("LeadCallHistory");
                });

            modelBuilder.Entity("CRMTest.Model.LeadQualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("client_id");

                    b.ToTable("LeadQualification");
                });

            modelBuilder.Entity("CRMTest.Model.LeadSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadSourceTb");
                });

            modelBuilder.Entity("CRMTest.Model.LeadStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadStatusTb");
                });

            modelBuilder.Entity("CRMTest.Model.Leads", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FollowUpNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NextFollowUp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("campaign_id")
                        .HasColumnType("int");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<int>("qualification_id")
                        .HasColumnType("int");

                    b.Property<int>("source_id")
                        .HasColumnType("int");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.Property<int>("status_id")
                        .HasColumnType("int");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("campaign_id");

                    b.HasIndex("client_id");

                    b.HasIndex("qualification_id");

                    b.HasIndex("source_id");

                    b.HasIndex("status_id");

                    b.HasIndex("updated_by");

                    b.ToTable("LeadsTb");
                });

            modelBuilder.Entity("CRMTest.Model.LeadsHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("lead_id")
                        .HasColumnType("int");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("lead_id");

                    b.HasIndex("updated_by");

                    b.ToTable("LeadsHistoryTb");
                });

            modelBuilder.Entity("CRMTest.Model.StaffRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffRoleTb");
                });

            modelBuilder.Entity("CRMTest.Model.StaffTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.Property<int>("status_id")
                        .HasColumnType("int");

                    b.Property<int>("task_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("staff_id");

                    b.HasIndex("status_id");

                    b.HasIndex("task_id");

                    b.ToTable("StaffTaskTb");
                });

            modelBuilder.Entity("CRMTest.Model.StaffTaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffTaskStatusTb");
                });

            modelBuilder.Entity("CRMTest.Model.Staffs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<int>("role_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("client_id");

                    b.HasIndex("role_id");

                    b.ToTable("StaffsTb");
                });

            modelBuilder.Entity("CRMTest.Model.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ScheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("created_by");

                    b.ToTable("TasksTb");
                });

            modelBuilder.Entity("CRMTest.Model.TasksHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("staffId")
                        .HasColumnType("int");

                    b.Property<int>("stafftask_id")
                        .HasColumnType("int");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("staffId");

                    b.HasIndex("stafftask_id");

                    b.ToTable("TasksHistory");
                });

            modelBuilder.Entity("CRMTest.Model.Campaign", b =>
                {
                    b.HasOne("CRMTest.Model.Client", "clients")
                        .WithMany("campaigns")
                        .HasForeignKey("client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Staffs", "staffs")
                        .WithMany("campaigns")
                        .HasForeignKey("created_by")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("clients");

                    b.Navigation("staffs");
                });

            modelBuilder.Entity("CRMTest.Model.ClientCustomers", b =>
                {
                    b.HasOne("CRMTest.Model.Staffs", "staffs")
                        .WithMany("clientCustomers")
                        .HasForeignKey("agent_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Campaign", "campaign")
                        .WithMany("clientCustomers")
                        .HasForeignKey("campaign_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Client", "client")
                        .WithMany("clientCustomers")
                        .HasForeignKey("client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.LeadSource", "sources")
                        .WithMany("clientCustomers")
                        .HasForeignKey("source_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("campaign");

                    b.Navigation("client");

                    b.Navigation("sources");

                    b.Navigation("staffs");
                });

            modelBuilder.Entity("CRMTest.Model.LeadCallHistory", b =>
                {
                    b.HasOne("CRMTest.Model.Staffs", "staffs")
                        .WithMany("leadCallHistories")
                        .HasForeignKey("agent_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Leads", "leads")
                        .WithMany("leadCallHistories")
                        .HasForeignKey("lead_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("leads");

                    b.Navigation("staffs");
                });

            modelBuilder.Entity("CRMTest.Model.LeadQualification", b =>
                {
                    b.HasOne("CRMTest.Model.Client", "client")
                        .WithMany("leadQualifications")
                        .HasForeignKey("client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("CRMTest.Model.Leads", b =>
                {
                    b.HasOne("CRMTest.Model.Campaign", "campaign")
                        .WithMany("leads")
                        .HasForeignKey("campaign_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Client", "client")
                        .WithMany("leads")
                        .HasForeignKey("client_id")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.LeadQualification", "leadQualification")
                        .WithMany("leads")
                        .HasForeignKey("qualification_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.LeadSource", "sources")
                        .WithMany("leads")
                        .HasForeignKey("source_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.LeadStatus", "status")
                        .WithMany("leads")
                        .HasForeignKey("status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Staffs", "staffs")
                        .WithMany("leads")
                        .HasForeignKey("updated_by")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("campaign");

                    b.Navigation("client");

                    b.Navigation("leadQualification");

                    b.Navigation("sources");

                    b.Navigation("staffs");

                    b.Navigation("status");
                });

            modelBuilder.Entity("CRMTest.Model.LeadsHistory", b =>
                {
                    b.HasOne("CRMTest.Model.Leads", "lead")
                        .WithMany("leadsHistories")
                        .HasForeignKey("lead_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Staffs", "staffs")
                        .WithMany("leadsHistories")
                        .HasForeignKey("updated_by")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("lead");

                    b.Navigation("staffs");
                });

            modelBuilder.Entity("CRMTest.Model.StaffTask", b =>
                {
                    b.HasOne("CRMTest.Model.Staffs", "staffs")
                        .WithMany("stafftasks")
                        .HasForeignKey("staff_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.StaffTaskStatus", "status")
                        .WithMany("tasks")
                        .HasForeignKey("status_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.Tasks", "tasks")
                        .WithMany("stafftask")
                        .HasForeignKey("task_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("staffs");

                    b.Navigation("status");

                    b.Navigation("tasks");
                });

            modelBuilder.Entity("CRMTest.Model.Staffs", b =>
                {
                    b.HasOne("CRMTest.Model.Client", "clients")
                        .WithMany("staffs")
                        .HasForeignKey("client_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.StaffRole", "roles")
                        .WithMany("staffs")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clients");

                    b.Navigation("roles");
                });

            modelBuilder.Entity("CRMTest.Model.Tasks", b =>
                {
                    b.HasOne("CRMTest.Model.Staffs", "staff")
                        .WithMany("tasks")
                        .HasForeignKey("created_by")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("staff");
                });

            modelBuilder.Entity("CRMTest.Model.TasksHistory", b =>
                {
                    b.HasOne("CRMTest.Model.Staffs", "staff")
                        .WithMany()
                        .HasForeignKey("staffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMTest.Model.StaffTask", "staffTask")
                        .WithMany("tasksHistories")
                        .HasForeignKey("stafftask_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("staff");

                    b.Navigation("staffTask");
                });

            modelBuilder.Entity("CRMTest.Model.Campaign", b =>
                {
                    b.Navigation("clientCustomers");

                    b.Navigation("leads");
                });

            modelBuilder.Entity("CRMTest.Model.Client", b =>
                {
                    b.Navigation("campaigns");

                    b.Navigation("clientCustomers");

                    b.Navigation("leadQualifications");

                    b.Navigation("leads");

                    b.Navigation("staffs");
                });

            modelBuilder.Entity("CRMTest.Model.LeadQualification", b =>
                {
                    b.Navigation("leads");
                });

            modelBuilder.Entity("CRMTest.Model.LeadSource", b =>
                {
                    b.Navigation("clientCustomers");

                    b.Navigation("leads");
                });

            modelBuilder.Entity("CRMTest.Model.LeadStatus", b =>
                {
                    b.Navigation("leads");
                });

            modelBuilder.Entity("CRMTest.Model.Leads", b =>
                {
                    b.Navigation("leadCallHistories");

                    b.Navigation("leadsHistories");
                });

            modelBuilder.Entity("CRMTest.Model.StaffRole", b =>
                {
                    b.Navigation("staffs");
                });

            modelBuilder.Entity("CRMTest.Model.StaffTask", b =>
                {
                    b.Navigation("tasksHistories");
                });

            modelBuilder.Entity("CRMTest.Model.StaffTaskStatus", b =>
                {
                    b.Navigation("tasks");
                });

            modelBuilder.Entity("CRMTest.Model.Staffs", b =>
                {
                    b.Navigation("campaigns");

                    b.Navigation("clientCustomers");

                    b.Navigation("leadCallHistories");

                    b.Navigation("leads");

                    b.Navigation("leadsHistories");

                    b.Navigation("stafftasks");

                    b.Navigation("tasks");
                });

            modelBuilder.Entity("CRMTest.Model.Tasks", b =>
                {
                    b.Navigation("stafftask");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿using CRMTest.Model;
using Microsoft.EntityFrameworkCore;

namespace CRMTest.CRMContext
{
    public class crmContext:DbContext
    {
        public crmContext(DbContextOptions<crmContext> option):base(option)
        {

        }


        public DbSet<CrmAdmins> CrmAdminsTb { get; set; }
        public DbSet<Client> ClientTb { get; set; }
        public DbSet<Campaign> CampaignTb { get; set; }
        public DbSet<Leads> LeadsTb { get; set; }
        public DbSet<LeadsHistory> LeadsHistoryTb { get; set; }
        public DbSet<LeadSource> LeadSourceTb { get; set; }
        public DbSet<LeadStatus> LeadStatusTb { get; set; }
        public DbSet<UserTaskStatus> StaffTaskStatusTb { get; set; }
        public DbSet<ClientCustomers> ClientCustomersTb { get; set; }
        public DbSet<UserRole> StaffRoleTb { get; set; }
        public DbSet<User> StaffsTb { get; set; }
        public DbSet<UserTask> StaffTaskTb { get; set; }
        public DbSet<Tasks> TasksTb { get; set; }
        public DbSet<TasksHistory> TasksHistoryTb { get; set; }
        public DbSet<ClientFeedback> ClientFeedbackTb { get; set; }
        public DbSet<LeadCallHistory> LeadCallHistoryTb { get; set; }
        public DbSet<LeadQualification> LeadQualificationTb { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Campaign>()
                .HasOne(c => c.clients)
                .WithMany(cl => cl.campaigns)
                .HasForeignKey(c => c.client_id);
            modelBuilder.Entity<Campaign>()
               .HasOne(c => c.user)
               .WithMany(cm => cm.campaigns)
               .HasForeignKey(c => c.created_by)
               .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Campaign>()
               .HasOne(c => c.leadSource)
               .WithMany(cm => cm.campaigns)
               .HasForeignKey(c => c.source_id)
               .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>()
                .HasOne(s => s.clients)
                .WithMany(cl => cl.users)
                .HasForeignKey(s=>s.client_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>()
                .HasOne(s => s.roles)
                .WithMany(r => r.staffs)
                .HasForeignKey(s => s.role_id);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.client)
                .WithMany(cl => cl.leads)
                .HasForeignKey(l => l.client_id)
                .OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.sources)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.source_id);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.status)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.status_id);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.user)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.user_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.user)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.created_by)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.user)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.updated_by)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.campaign)
                .WithMany(c => c.leads)
                .HasForeignKey(l => l.campaign_id);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.leadQualification)
                .WithMany(lq => lq.leads)
                .HasForeignKey(l => l.qualification_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<LeadsHistory>()
                .HasOne(lh => lh.lead)
                .WithMany(l => l.leadsHistories)
                .HasForeignKey(l => l.lead_id);
            modelBuilder.Entity<LeadsHistory>()
                .HasOne(lh => lh.user)
                .WithMany(l => l.leadsHistories)
                .HasForeignKey(l => l.updated_by)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserTask>()
                .HasOne(st => st.tasks)
                .WithMany(t => t.stafftask)
                .HasForeignKey(st => st.task_id);
            modelBuilder.Entity<UserTask>()
                .HasOne(st=>st.user)
                .WithMany(s=>s.stafftasks)
                .HasForeignKey(st =>st.user_id);
            modelBuilder.Entity<UserTask>()
                .HasOne(st => st.status)
                .WithMany(sts => sts.tasks)
                .HasForeignKey(st => st.status_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ClientCustomers>()
                .HasOne(cc => cc.sources)
                .WithMany(s => s.clientCustomers)
                .HasForeignKey(cc => cc.source_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ClientCustomers>()
                .HasOne(cc => cc.client)
                .WithMany(c => c.clientCustomers)
                .HasForeignKey(cc => cc.client_id);
            modelBuilder.Entity<ClientCustomers>()
                .HasOne(cc => cc.user)
                .WithMany(s => s.clientCustomers)
                .HasForeignKey(cc => cc.agent_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ClientCustomers>()
                .HasOne(cc => cc.campaign)
                .WithMany(c => c.clientCustomers)
                .HasForeignKey(cc => cc.campaign_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Tasks>()
                .HasOne(t => t.staff)
                .WithMany(s => s.tasks)
                .HasForeignKey(t => t.created_by)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<LeadCallHistory>()
                .HasOne(ch => ch.leads)
                .WithMany(l => l.leadCallHistories)
                .HasForeignKey(ch => ch.lead_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<LeadCallHistory>()
                .HasOne(ch => ch.user)
                .WithMany(l => l.leadCallHistories)
                .HasForeignKey(ch => ch.agent_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<TasksHistory>()
                .HasOne(th => th.staffTask)
                .WithMany(s => s.tasksHistories)
                .HasForeignKey(ch => ch.stafftask_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<LeadQualification>()
                .HasOne(lq => lq.client)
                .WithMany(c => c.leadQualifications)
                .HasForeignKey(lq => lq.client_id);
            modelBuilder.Entity< ClientFeedback >()
                .HasOne(cf=>cf.client)
                .WithMany(c=>c.clientFeedbacks)
                .HasForeignKey(cf=>cf.client_id);
           

            base.OnModelCreating(modelBuilder);
        }

    }
}

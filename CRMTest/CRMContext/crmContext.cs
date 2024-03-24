using CRMTest.Model;
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
        public DbSet<StaffTaskStatus> StaffTaskStatusTb { get; set; }
        public DbSet<ClientCustomers> ClientCustomersTb { get; set; }
        public DbSet<StaffRole> StaffRoleTb { get; set; }
        public DbSet<Staffs> StaffsTb { get; set; }
        public DbSet<StaffTask> StaffTaskTb { get; set; }
        public DbSet<Tasks> TasksTb { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Campaign>()
                .HasOne(c => c.clients)
                .WithMany(cl => cl.campaigns)
                .HasForeignKey(c => c.client_id);
            modelBuilder.Entity<Campaign>()
               .HasOne(c => c.staffs)
               .WithMany(cm => cm.campaigns)
               .HasForeignKey(c => c.created_by)
               .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Staffs>()
                .HasOne(s => s.clients)
                .WithMany(cl => cl.staffs)
                .HasForeignKey(s=>s.client_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Staffs>()
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
                .HasOne(l => l.staffs)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.staff_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.staffs)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.created_by)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.staffs)
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
                .HasOne(lh => lh.staffs)
                .WithMany(l => l.leadsHistories)
                .HasForeignKey(l => l.updated_by)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StaffTask>()
                .HasOne(st => st.tasks)
                .WithMany(t => t.stafftask)
                .HasForeignKey(st => st.task_id);
            modelBuilder.Entity<StaffTask>()
                .HasOne(st=>st.staffs)
                .WithMany(s=>s.stafftasks)
                .HasForeignKey(st =>st.staff_id);
            modelBuilder.Entity<StaffTask>()
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
                .HasOne(cc => cc.staffs)
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
                .HasOne(ch => ch.staffs)
                .WithMany(l => l.leadCallHistories)
                .HasForeignKey(ch => ch.agent_id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<TasksHistory>()
                .HasOne(th => th.staffTask)
                .WithMany(s => s.tasksHistories)
                .HasForeignKey(ch => ch.stafftask_id)
                .OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(modelBuilder);
        }

    }
}

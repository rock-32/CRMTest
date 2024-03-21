using CRMTest.Model;
using Microsoft.EntityFrameworkCore;

namespace CRMTest.CRMContext
{
    public class crmContext:DbContext
    {
        public crmContext(DbContextOptions<crmContext> option):base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasOne(d => d.clients)
                .WithMany(c => c.departments)
                .HasForeignKey(d => d.Client_Id);

            base.OnModelCreating(modelBuilder);
        }

    }
}

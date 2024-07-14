using Management.DataAccess.Concrete.EfCore.Mapping;
using Management.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Concrete.EfCore.Contexts
{
    public class ManagementContext : IdentityDbContext<AppUser, AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;database=ManagementDB;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new ReportMap());
            modelBuilder.ApplyConfiguration(new UrgencyMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Work> Works { get; set; }
        public DbSet<Urgency> Urgencies { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Notification> Notifications { get; set; }


    }
}

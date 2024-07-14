using Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Management.DataAccess.Concrete.EfCore.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Surname).HasMaxLength(100);

            builder.HasMany(x => x.Works).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId).OnDelete(DeleteBehavior.SetNull);


        }
    }
}

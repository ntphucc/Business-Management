using Management.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Management.DataAccess.Concrete.EfCore.Mapping
{
    public class UrgencyMap : IEntityTypeConfiguration<Urgency>
    {
        public void Configure(EntityTypeBuilder<Urgency> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(100);
        }
    }
}

using Data.Entities.Projects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;
public class UnitConfigurations : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasQueryFilter(m => !m.IsDeleted);
        builder.OwnsOne(x => x.AdditionalInformation, cb => cb.ToJson());
        builder.OwnsMany(x => x.StreetInformation, cb => cb.ToJson());
    }
}

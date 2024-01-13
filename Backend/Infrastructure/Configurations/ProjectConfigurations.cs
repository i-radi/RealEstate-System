using Data.Entities.Projects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;
public class ProjectConfigurations : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasQueryFilter(m => !m.IsDeleted);
        builder.OwnsOne(x => x.AdditionalInformation, cb => cb.ToJson());
        builder.OwnsMany(x => x.StreetInformation, cb => cb.ToJson());
    }
}

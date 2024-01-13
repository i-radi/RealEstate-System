using Data.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;
public class UserPropertyConfigurations : IEntityTypeConfiguration<UserProperties>
{
    public void Configure(EntityTypeBuilder<UserProperties> builder)
    {
        builder.HasKey(up => new { up.UserId, up.PropertyId });
    }
}
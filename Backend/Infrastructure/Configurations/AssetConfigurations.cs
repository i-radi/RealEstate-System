using Data.Entities.Auctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;
public class AssetConfigurations : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.HasQueryFilter(m => !m.IsDeleted);
        builder.OwnsOne(x => x.AdditionalInformation, cb => cb.ToJson());
        builder.OwnsMany(x => x.StreetInformation, cb => cb.ToJson());
        builder.OwnsOne(x => x.LengthAndBorder, cb =>
        {
            cb.ToJson();
            cb.OwnsOne(x => x.FromNorth);
            cb.OwnsOne(x => x.FromWest);
            cb.OwnsOne(x => x.FromEast);
            cb.OwnsOne(x => x.FromSouth);
        });
    }
}

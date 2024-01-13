﻿using Data.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;
public class PropertyConfigurations : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.HasQueryFilter(m => !m.IsDeleted);
        builder.OwnsOne(x => x.AdditionalInformation, cb => cb.ToJson());
        builder.OwnsMany(x => x.StreetInformation, cb => cb.ToJson());
    }
}
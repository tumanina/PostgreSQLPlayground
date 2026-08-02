using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlPlayground.Database.Entities;

namespace PostgreSqlPlayground.Configurations;

internal class SubscriptionEntityConfiguration: IEntityTypeConfiguration<SubscriptionEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionEntity> builder)
    {
        builder.Property(e => e.EventType).HasConversion<string>();
        builder.HasIndex(u => new { u.Tenant, u.EventType });
    }
}

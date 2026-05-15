using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlPlayground;

namespace PostgreSqlPlayground.Configurations;

internal class SubscriptionConfiguration: IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.Property(e => e.EventType).HasConversion<string>();
        builder.HasIndex(u => new { u.Tenant, u.EventType });
    }
}

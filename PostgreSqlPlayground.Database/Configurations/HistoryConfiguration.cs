using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PostgreSqlPlayground.Configurations;

internal class HistoryConfiguration : IEntityTypeConfiguration<History>
{
    public void Configure(EntityTypeBuilder<History> builder)
    {
        builder.Property(e => e.EventType).HasConversion<string>();
        builder.Property(x => x.Response).HasMaxLength(1000);
        builder.HasIndex(u => new { u.Tenant, u.EventType, u.ResponseStatus, u.SentAt });
        builder.HasIndex(u => new { u.SentAt });
    }
}

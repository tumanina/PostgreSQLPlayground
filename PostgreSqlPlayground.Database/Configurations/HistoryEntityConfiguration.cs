using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlPlayground.Database.Entities;

namespace PostgreSqlPlayground.Configurations;

internal class HistoryEntityConfiguration : IEntityTypeConfiguration<HistoryEntity>
{
    public void Configure(EntityTypeBuilder<HistoryEntity> builder)
    {
        builder.Property(e => e.EventType).HasConversion<string>();
        builder.Property(x => x.Response).HasMaxLength(1000);
        builder.HasIndex(u => new { u.Tenant, u.EventType, u.ResponseStatus, u.SentAt });
        builder.HasIndex(u => new { u.SentAt });
    }
}

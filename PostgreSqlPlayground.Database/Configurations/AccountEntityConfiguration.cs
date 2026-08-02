using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlPlayground.Database.Entities;

namespace PostgreSqlPlayground.Configurations;

internal class AccountEntityConfiguration: IEntityTypeConfiguration<AccountEntity>
{
    public void Configure(EntityTypeBuilder<AccountEntity> builder)
    {
        builder.Property<uint>("xmin")
           .HasColumnName("xmin")
           .HasColumnType("xid")
           .ValueGeneratedOnAddOrUpdate()
           .IsConcurrencyToken();
    }
}

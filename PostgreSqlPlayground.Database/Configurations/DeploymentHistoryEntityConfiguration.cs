using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlPlayground.Database.Entities;

namespace PostgreSqlPlayground.Database.Configurations
{
    public class DeploymentConfiguration : IEntityTypeConfiguration<DeploymentHistoryEntity>
    {
        public void Configure(EntityTypeBuilder<DeploymentHistoryEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status)
                .HasConversion<string>();

            builder.OwnsOne(c => c.Settings, settingsBuilder =>
            {
                settingsBuilder.ToJson();

                settingsBuilder.OwnsOne(t => t.Kafka);
                settingsBuilder.OwnsOne(t => t.Database);
                settingsBuilder.OwnsOne(t => t.Resources);

                settingsBuilder.Navigation(t => t.Kafka).IsRequired(false);
                settingsBuilder.Navigation(t => t.Database).IsRequired(false);
                settingsBuilder.Navigation(t => t.Resources).IsRequired(false);
            });
        }
    }
}

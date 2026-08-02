using Microsoft.EntityFrameworkCore;
using PostgreSqlPlayground.Database.Entities;

namespace PostgreSqlPlayground.Database;

public class PlaygroundContext : DbContext
{
    public PlaygroundContext(DbContextOptions options) : base(options) { }
    public PlaygroundContext() { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlaygroundContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<SubscriptionEntity> Subscriptions { get; set; }
    public DbSet<HistoryEntity> History { get; set; }
    public DbSet<DeploymentHistoryEntity> DeploymentHistory { get; set; }
    public DbSet<ProjectEntity> Projects { get; set; }
    public DbSet<AccountEntity> Accounts { get; set; }
}

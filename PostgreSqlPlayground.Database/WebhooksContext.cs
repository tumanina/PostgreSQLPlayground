using Microsoft.EntityFrameworkCore;

namespace PostgreSqlPlayground;

public class WebhooksContext : DbContext
{
    public WebhooksContext(DbContextOptions options) : base(options) { }
    public WebhooksContext() { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WebhooksContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<History> History { get; set; }
}

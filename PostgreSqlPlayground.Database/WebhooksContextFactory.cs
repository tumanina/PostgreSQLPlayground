using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PostgreSqlPlayground;

namespace Jedlix.Webhooks.Data.Database;

internal class WebhooksContextFactory : IDesignTimeDbContextFactory<WebhooksContext>
{
    public WebhooksContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<WebhooksContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=pgpwd4habr");

        return new WebhooksContext(optionsBuilder.Options);
    }
}
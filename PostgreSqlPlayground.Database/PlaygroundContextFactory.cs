using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PostgreSqlPlayground.Database;

internal class PlaygroundContextFactory : IDesignTimeDbContextFactory<PlaygroundContext>
{
    public PlaygroundContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PlaygroundContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=postgres");

        return new PlaygroundContext(optionsBuilder.Options);
    }
}
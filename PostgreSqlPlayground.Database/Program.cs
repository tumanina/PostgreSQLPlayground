using Microsoft.EntityFrameworkCore;
using PostgreSqlPlayground;

var connectionString = "Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=pgpwd4habr";
var builder = new DbContextOptionsBuilder<DbContext>();

builder.EnableSensitiveDataLogging()
       .UseNpgsql(connectionString,
                     opts =>
                     {
                         opts.CommandTimeout((int)TimeSpan.FromMinutes(120).TotalSeconds);
                         opts.EnableRetryOnFailure();
                     });

var dbContext = new WebhooksContext(builder.Options);
dbContext.Database.Migrate();

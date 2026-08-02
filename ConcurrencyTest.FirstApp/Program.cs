using Microsoft.EntityFrameworkCore;
using PostgreSqlPlayground.Database;

var contextOptions = new DbContextOptionsBuilder<PlaygroundContext>()
    .UseNpgsql("Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=postgres")
    .Options;

using var context = new PlaygroundContext(contextOptions);

var account = await context.Accounts.FirstAsync();

Console.WriteLine("Loaded");

var xmin = context.Entry(account)
    .Property<uint>("xmin")
    .CurrentValue;

Console.WriteLine($"Loaded xmin = {xmin}");

Console.WriteLine("Click any button to update");
Console.ReadLine();

account.Balance += 100;

try
{
    await context.SaveChangesAsync();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

    xmin = context.Entry(account)
        .Property<uint>("xmin")
        .CurrentValue;
    Console.WriteLine($"Loaded xmin = {xmin}");
}

Console.WriteLine("Saved");

Console.ReadLine();
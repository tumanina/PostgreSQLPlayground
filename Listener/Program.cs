using Npgsql;

var connectionString = "Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=postgres";

await using var connection = new NpgsqlConnection(connectionString);

await connection.OpenAsync();

connection.Notification += (_, e) =>
{
    Console.WriteLine($"Channel: {e.Channel}");
    Console.WriteLine($"Payload: {e.Payload}");
};

await using var cmd = new NpgsqlCommand(
    "LISTEN inbox;",
    connection);

await cmd.ExecuteNonQueryAsync();

Console.WriteLine("Listening...");

while (true)
{
    await connection.WaitAsync();
}

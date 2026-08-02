using Npgsql;

var connectionString = "Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=postgres";
await using var connection = new NpgsqlConnection(connectionString);

await connection.OpenAsync();

while (true)
{
    var message = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(message))
        continue;

    await using var cmd = new NpgsqlCommand(
        "SELECT pg_notify('inbox', @message);",
        connection);

    cmd.Parameters.AddWithValue("message", message);

    await cmd.ExecuteNonQueryAsync();
}
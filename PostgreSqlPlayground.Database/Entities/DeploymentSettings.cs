namespace PostgreSqlPlayground.Database.Entities;

public class DeploymentSettings
{
    public int Replicas { get; set; }
    public ResourceSettings Resources { get; set; } = new();
    public DatabaseSettings Database { get; set; } = new();
    public KafkaSettings Kafka { get; set; } = new();
}

public class ResourceSettings
{
    public string CpuRequest { get; set; } = "500m";
    public string CpuLimit { get; set; } = "1000m";
    public string MemoryRequest { get; set; } = "512Mi";
    public string MemoryLimit { get; set; } = "1Gi";
}

public class KafkaSettings
{
    public bool Enabled { get; set; }
    public string BootstrapServers { get; set; } = string.Empty;
    public string Topic { get; set; } = string.Empty;
    public int Partitions { get; set; }
    public bool IdempotentProducer { get; set; }
}

public class DatabaseSettings
{
    public string Provider { get; set; } = "PostgreSQL";
    public string Version { get; set; } = "17";
    public string DatabaseName { get; set; } = string.Empty;
    public int MaxConnections { get; set; }
}
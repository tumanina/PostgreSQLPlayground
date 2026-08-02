namespace PostgreSqlPlayground.Database.Entities;

public class DeploymentHistoryEntity
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public ProjectEntity? Project { get; set; }
    public DeploymentStatus Status { get; set; }
    public DeploymentSettings Settings { get; set; } = new();
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? CompletedAtUtc { get; set; }
}

public enum DeploymentStatus
{
    Pending,
    Running,
    Succeeded,
    Failed,
    Cancelled
}
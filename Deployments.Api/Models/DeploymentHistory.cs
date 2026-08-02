using PostgreSqlPlayground.Database.Entities;

namespace Deployments.Api.Models;

public record DeploymentHistory
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public DeploymentStatus Status { get; set; }
    public DeploymentSettings Settings { get; set; } = new();
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAtUtc { get; set; }
}
namespace PostgreSqlPlayground.Database.Entities;

public class ProjectEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<DeploymentHistoryEntity> Deployments { get; set; } = [];
}

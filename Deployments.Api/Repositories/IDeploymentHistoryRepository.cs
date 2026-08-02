using PostgreSqlPlayground.Database.Entities;

namespace Deployments.Api.Repositories;

public interface IDeploymentHistoryRepository
{
    public Task<DeploymentHistoryEntity> CreateDeployment(DeploymentHistoryEntity deployment);
    public Task<IEnumerable<DeploymentHistoryEntity>> GetDeploymentHistory(string topic);
}

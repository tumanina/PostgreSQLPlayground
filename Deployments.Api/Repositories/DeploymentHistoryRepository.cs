using Microsoft.EntityFrameworkCore;
using PostgreSqlPlayground.Database;
using PostgreSqlPlayground.Database.Entities;

namespace Deployments.Api.Repositories;

public class DeploymentHistoryRepository(PlaygroundContext dbContext) : IDeploymentHistoryRepository
{
    private readonly PlaygroundContext _dbContext = dbContext;

    public async Task<DeploymentHistoryEntity> CreateDeployment(DeploymentHistoryEntity deployment)
    {
        if (deployment.Id == Guid.Empty)
        {
            deployment.Id = Guid.NewGuid();
        }
        _dbContext.DeploymentHistory.Add(deployment);
        await _dbContext.SaveChangesAsync();

        return deployment;
    }

    public async Task<IEnumerable<DeploymentHistoryEntity>> GetDeploymentHistory(string topic)
    {
        return await _dbContext.DeploymentHistory.Where(d => d.Settings.Kafka.Topic == topic).ToListAsync();
    }
}

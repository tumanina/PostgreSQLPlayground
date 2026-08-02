using Deployments.Api.Models;
using Deployments.Api.Repositories;
using PostgreSqlPlayground.Database.Entities;

namespace Deployments.Api.Services;

public class DeploymentHistoryService(IDeploymentHistoryRepository repository) : IDeploymentHistoryService
{
    private readonly IDeploymentHistoryRepository _repository = repository;

    public async Task<DeploymentHistory> CreateDeployment(DeploymentHistory deployment)
    {
        var deplymentEntity = new DeploymentHistoryEntity
        {
            Id = deployment.Id,
            ProjectId = deployment.ProjectId,
            Settings = deployment.Settings,
            CreatedAtUtc = deployment.CreatedAtUtc,
            CompletedAtUtc = deployment.CompletedAtUtc,
            Status = deployment.Status
        };

        var createdDeployment = await _repository.CreateDeployment(deplymentEntity);

        return new DeploymentHistory
        {
            Id = createdDeployment.Id, 
            ProjectId = createdDeployment.ProjectId,
            Settings = createdDeployment.Settings,
            CreatedAtUtc = createdDeployment.CreatedAtUtc,
            CompletedAtUtc = createdDeployment.CompletedAtUtc,
            Status = createdDeployment.Status
        };
    }

    public async Task<IEnumerable<DeploymentHistory>> GetDeploymentHistory(string topic)
    {
        return (await _repository.GetDeploymentHistory(topic)).Select(d => new DeploymentHistory
        {
            Id = d.Id,
            ProjectId = d.ProjectId,
            Settings = d.Settings,
            CreatedAtUtc = d.CreatedAtUtc,
            CompletedAtUtc = d.CompletedAtUtc,
            Status = d.Status
        });
    }
}

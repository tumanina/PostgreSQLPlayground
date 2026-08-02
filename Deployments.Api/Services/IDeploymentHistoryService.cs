using Deployments.Api.Models;

namespace Deployments.Api.Services
{
    public interface IDeploymentHistoryService
    {
        public Task<DeploymentHistory> CreateDeployment(DeploymentHistory deployment);
        public Task<IEnumerable<DeploymentHistory>> GetDeploymentHistory(string topic);
    }
}

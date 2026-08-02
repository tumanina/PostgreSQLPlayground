using Deployments.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Deployments.Api.Models;

namespace Deployments.Api.Controllers
{
    [ApiController]
    [Route("deplyments")]
    public class DeploymentsController(IDeploymentHistoryService historyService) : ControllerBase
    {
        private readonly IDeploymentHistoryService _historyService = historyService;

        [HttpGet(Name = "GetDeploymentHistory")]
        public async Task<IActionResult> Get(string topic)
        {
            var history = await _historyService.GetDeploymentHistory(topic);

            return Ok(history);
        }

        [HttpPost(Name = "CreateDeploymentHistory")]
        public async Task<IActionResult> Create([FromBody] DeploymentHistory history)
        {
            var createdHistory = await _historyService.CreateDeployment(history);

            return Ok(createdHistory);
        }
    }
}

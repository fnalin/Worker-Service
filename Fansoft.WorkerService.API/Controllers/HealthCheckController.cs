using Microsoft.AspNetCore.Mvc;
using System;

namespace Fansoft.WorkerService.API.Controllers
{
    [ApiController]
    [Route("api/healthcheck")]
    public class HealthCheckController: ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.UtcNow);
        }
        
    }
}

using Fansoft.WorkerService.Domain;
using Fansoft.WorkerService.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fansoft.WorkerService.API.Controllers
{
    [ApiController]
    [Route("api/command")]
    public class CommandController : ControllerBase
    {
        private readonly ICommandRepository _commandRepository;

        public CommandController(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        [HttpPost]
        public IActionResult SetCommand([FromBody]Message message)
        {
            _commandRepository.SetMessage(message);
            return Ok(_commandRepository.GetMessage());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Phonebook.Commands;
using Phonebook.WebApi.Models;
using System.Net;

namespace Phonebook.WebApi.Controllers
{
    [Route("api/command")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly CommandInvoker _commandInvoker;

        public CommandController(CommandInvoker commandInvoker)
        {
            _commandInvoker = commandInvoker;
        }

        [Route("execute")]
        [HttpPost]
        public IActionResult ExecuteCommand(ExecuteCommandRequest request)
        {
            if (string.IsNullOrEmpty(request?.Input))
            {
                return BadRequest();
            }

            try
            {
                var text = _commandInvoker.Execute(request.Input);

                return new JsonResult(new { text = text });
            }
            catch
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
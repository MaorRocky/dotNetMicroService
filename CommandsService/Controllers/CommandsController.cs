using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public CommandsController()
        {
        }

        [HttpPost]
        public ActionResult Test()
        {
            Console.WriteLine("Test");
            return Ok("Test Platform");
        }
    }
}
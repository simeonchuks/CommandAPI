using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Models;


namespace CommandAPI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly CommandContext _context;

        public CommandsController(CommandContext context)
        {
            _context = context;
        }

        //Http Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommandItems()
        {
            return _context.CommandItems;
        }




        //THIS METHOD IS USED TO RETURN HARD CODDED DATA
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "This is", "my own", "Hard codded", "message" };
        // }
    }
}
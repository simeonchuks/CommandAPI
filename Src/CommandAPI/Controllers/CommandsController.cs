using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace CommandAPI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "This is", "my own", "Hard codded", "message" };
        }
    }
}
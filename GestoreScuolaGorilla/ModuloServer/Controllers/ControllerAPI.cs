using Microsoft.AspNetCore.Mvc;

namespace ModuloServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello World");
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetInt(int id)
        {
            return Ok($"You requested with this id: {id}");
        }

        [HttpPost]
        public ActionResult<string> Post()
        {
            return Ok("You requested with POST");
        }
    }
}
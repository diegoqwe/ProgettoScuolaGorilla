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

        //http get se viene richiesto di restituire il numero 50
        [HttpGet("{id}")]
        public ActionResult<string> GetInt(int id)
        {
            return Ok($"You requested with this id: {id}");
        }
    }
}
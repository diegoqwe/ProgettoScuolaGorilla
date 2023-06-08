using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
using MySql.Data.MySqlClient;

namespace ModuloServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //DATABASE ACCESS VARIABLES
        private const string datasource = "localhost";
        private const string port = "3306";
        private const string username = "root";
        private const string passwd = "root";

        MySqlConnection connection = new MySqlConnection($"datasource={datasource};port={port};username={username};password={passwd}");


        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello World");
        }

        [HttpPost("{id}")]
        public ActionResult<string> GetInt(Voti voti)
        {
            return Ok($"You requested with this id: {voti}");
        }

        [HttpPost("studenti")]
        public IActionResult PostStudente([FromBody] Studente studente)
        {
            connection.Open();
            string insertStudenteQuery = $"INSERT INTO studenti (nome, cognome) VALUES ('{studente.Nome}', '{studente.Cognome}')";
            MySqlCommand cmd = new MySqlCommand(insertStudenteQuery, connection);
            return Ok("Studente salvato con successo.");
        }

        [HttpPost]
        public ActionResult<string> Post()
        {
            return Ok("You requested with POST");
        }
    }
}
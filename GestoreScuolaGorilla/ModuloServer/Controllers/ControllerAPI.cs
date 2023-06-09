using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
using Npgsql;
using Microsoft.AspNetCore.Hosting.Server;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;
using System.Collections.Generic;

namespace ModuloServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //DATABASE ACCESS VARIABLES
        private const string datasource = "localhost";
        private const string port = "7777";
        private const string database = "mydatabase"; 
        private const string username = "postgres";
        private const string passwd = "samuele01";



        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello World");
        }

        [HttpPost("voti")]
        public ActionResult<string> GetInt(Voti voti)
        {
            return Ok($"You requested with this id: {voti}");
        }

        [HttpPost("studenti")]
        public ActionResult<string> PostStudente(Studente studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO STUDENTI (nome,cognome,id_matricola) VALUES ('{studente.Nome}', '{studente.Cognome}','{studente.Matricola}','{studente.IdClasse}')";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }
    }
}
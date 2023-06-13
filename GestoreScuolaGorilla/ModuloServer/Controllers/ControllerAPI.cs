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

        [HttpPost("studenti")]
        public ActionResult<string> PostStudente(Studente studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO STUDENTI (nome,cognome,id_matricola,id_classe) VALUES ('{studente.Nome}', '{studente.Cognome}','{studente.Matricola}','{studente.IdClasse}')";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpPost("classi")]
        public ActionResult<string> PostClasse(Classe classe)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO CLASSI (id_classe) VALUES ('{classe.IdClasse}')";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpPost("materie")]
        public ActionResult<string> PostMaterie(List<string> values)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO MATERIE (id_materie, id_classe) VALUES ('{values[0]}', '{values[1]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpGet("materie")]
        public ActionResult<List<string>> GetMaterie(string id_classe)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> materie = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM MATERIE WHERE ID_CLASSE = '{id_classe}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    materie.Add(rdr.GetString(0));
                }
            }
            return Ok(materie);
        }

        [HttpGet("classi")]
        public ActionResult<List<string>> GetClassi()
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> classi = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM CLASSI";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    classi.Add(rdr.GetString(0));
                }
            }
            return Ok(classi);
        }
    }
}
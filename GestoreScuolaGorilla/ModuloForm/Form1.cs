using ClassLibrary1;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace ModuloForm
{
    public partial class Form1 : Form
    {
        private const string BaseUrl = "http://192.168.11.66:10212/values";
        private readonly HttpClient client;
        Scuola s = new Scuola();

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async Task<List<string>> getMaterie(string id_classe)
        {
            string getmaterieUrl = BaseUrl + $"/materie?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<string>>(getmaterieUrl);
            return responseStudente;
        }

        private async Task<List<Studente>> getStudenti(string id_classe)
        {
            string getstudentiUrl = BaseUrl + $"/studenti?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<Studente>>(getstudentiUrl);
            return responseStudente;
        }

        private async Task<List<string>> getClassi()
        {
            string getclassiUrl = BaseUrl + "/classi";
            var responseClasse = await client.GetFromJsonAsync<List<string>>(getclassiUrl);
            return responseClasse;
        }

        private async void postMaterie(string materia, string id_classe)
        {
            List<string> values = new List<string>();
            values.Add(materia);
            values.Add(id_classe);
            string postmaterieUrl = BaseUrl + "/materie";
            var responseStudente = await client.PostAsJsonAsync(postmaterieUrl, values);
        }

        private async void postStudente(string nome, string cognome, string id_studente, string id_classe)
        {
            List<string> values = new List<string>();
            values.Add(nome);
            values.Add(cognome);
            values.Add(id_studente);
            values.Add(id_classe);
            string poststudenteUrl = BaseUrl + "/studenti";
            var responseStudente = await client.PostAsJsonAsync(poststudenteUrl, values);
        }

        private async void postClasse(string id_classe)
        {
            List<string> values = new List<string>();
            values.Add(id_classe);
            string postclasseUrl = BaseUrl + "/classi";
            var responseStudente = await client.PostAsJsonAsync(postclasseUrl, values);
        }
    }
}
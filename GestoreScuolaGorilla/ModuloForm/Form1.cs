using ClassLibrary1;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace ModuloForm
{
    public partial class Form1 : Form
    {
        private const string BaseUrl = "http://localhost:5212/values";
        private readonly HttpClient client;
        Scuola s = new Scuola();

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            initializeClassi();
        }

        private async void initializeClassi()
        {
            List<string> classi = new List<string>();
            classi = await getClassi();

            foreach (string classe in classi)
            {
                s.addClasse(new Classe(classe));
            }

            label1.Text = s.getClasse(0).IdClasse;
            label2.Text = s.getClasse(1).IdClasse;
            label3.Text = s.getClasse(2).IdClasse;
        }

        private async Task<List<string>> getMaterie(string id_classe)
        {
            string getmaterieUrl = BaseUrl + $"/materie?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<string>>(getmaterieUrl);
            return responseStudente;
        }

        private async Task<List<Studente>> getStudenti()
        {
            string getstudentiUrl = BaseUrl + "/studenti";
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



        private async void btnPostStudente_Click(object sender, EventArgs e)
        {
            /*
            List<string> materie = new List<string>();
            materie.Add("aaa");
            materie.Add("bbb");
            materie.Add("ccc");

            string postmaterieUrl = BaseUrl + "/materie";
            var responseStudente = await client.PostAsJsonAsync(postmaterieUrl, materie);
            MessageBox.Show(responseStudente.ToString());
            
            if (responseStudente.IsSuccessStatusCode)
            {
                Console.WriteLine("Richiesta per creare studente inviata con successo.");
            }
            else
            {
                Console.WriteLine("Errore durante l'invio della richiesta per creare studente.");
            }
            */
        }
    }
}
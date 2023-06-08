using System.Net.Http.Json;

namespace ModuloForm
{
    public partial class Form1 : Form
    {
        private const string BaseUrl = "http://localhost:5000/values";
        private readonly HttpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPostStudente_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var nuovoStudente = new Studente
                {
                    Nome = "Mario",
                    Cognome = "Rossi"
                };

                // Invio della richiesta POST per creare un nuovo studente
                var responseStudente = await client.PostAsJsonAsync("http://localhost:5000/values/studenti", nuovoStudente);
                if (responseStudente.IsSuccessStatusCode)
                {
                    Console.WriteLine("Richiesta per creare studente inviata con successo.");
                }
                else
                {
                    Console.WriteLine("Errore durante l'invio della richiesta per creare studente.");
                }
            }
        }
    }
}
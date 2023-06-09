using ClassLibrary1;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace ModuloForm
{
    public partial class Form1 : Form
    {
        private const string BaseUrl = "http://localhost:5212/values";
        private readonly HttpClient client;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void btnPostStudente_Click(object sender, EventArgs e)
        {
            Studente s = new Studente("Zio", "Sammy");

            string postStudenteUrl = BaseUrl + "/studenti";
            var responseStudente = await client.PostAsJsonAsync(postStudenteUrl, s);
            MessageBox.Show(responseStudente.ToString());
            
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
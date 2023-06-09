using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Classe
    {
        private List<Studente> studenti;
        private string idClasse;
        public Classe()
        {
            studenti = new List<Studente>();
            idClasse = "";
        }
        public Classe(string idClasse)
        {
            studenti = new List<Studente>();
            this.idClasse = idClasse;
        }
        public void addStudente(Studente s)
        {
            studenti.Add(s);
        }
        public void removeStudente(Studente s)
        {
            studenti.Remove(s);
        }
        public Studente getStudente(int index)
        {
            return studenti[index];
        }
        public int getStudenteCount()
        {
            return studenti.Count;
        }
        public string IdClasse
        {
            get
            {
                return idClasse;
            }
            set
            {
                idClasse = value;
            }
        }
    }
}

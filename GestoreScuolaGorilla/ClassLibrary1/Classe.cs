using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Classe
    {
        private List<string> materie;
        private List<Studente> studenti;
        private string idClasse;
        public Classe()
        {
            studenti = new List<Studente>();
            idClasse = "";
            materie = new List<string>();
        }
        public Classe(string idClasse)
        {
            studenti = new List<Studente>();
            this.idClasse = idClasse;
            materie = new List<string>();
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

        public void addMateria(string materia)
        {
            materie.Add(materia);
        }

        public void removeMateria(string materia)
        {
            materie.Remove(materia);
        }

        public string getMateria(int index)
        {
            return materie[index];
        }

        public int getMaterieCount()
        {
            return materie.Count;
        }
    }
}

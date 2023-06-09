using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Scuola
    {
        private List<string> materie;
        private List<Classe> classi;

        public Scuola()
        {
            materie = new List<string>();
            classi = new List<Classe>();
        }

        public void addMaterie(string materia) 
        {
            materia = materia.ToLower();
            if (!materie.Contains(materia))
            {
                materie.Add(materia);
            }
        }

        public string getMaterieAtIndex(int index)
        {
            return materie[index];
        }

        public List<string> getMaterie()
        {
            return materie;
        }

        public Classe getClasse(int index)
        {
            return classi[index];
        }


        public Classe getClasseByID(string idClasse)
        {
            idClasse = idClasse.ToLower();
            foreach (Classe c in classi)
            {
                if (c.IdClasse == idClasse)
                    return c;
            }
            return null;
        }

    }
}

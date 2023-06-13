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
        private List<Classe> classi;

        public Scuola()
        {
            classi = new List<Classe>();
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

        public void addClasse(Classe c)
        {
            classi.Add(c);
        }

    }
}

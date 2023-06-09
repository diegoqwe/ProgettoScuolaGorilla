namespace ClassLibrary1
{
    public class Voti
    {
        protected List<double> voto;

        string materia;

        public Voti()
        {
            voto = new List<double>();
            materia = "";
        }

        public Voti(string materia)
        {
            voto = new List<double>();
            this.materia = materia;
        }

        public Voti (string materia, double voto)
        {
            this.materia = materia;
            this.voto = new List<double>();
            this.voto.Add(voto);
        }

        public void add(double v)
        {
            voto.Add(v);
        }

        public void remove(double v)
        {
            voto.Remove(v);
        }

        public double Media()
        {
            double media = 0;
            foreach (double v in voto)
            {
                media += v;
            }
            return media / voto.Count;
        }

        public double getVoto(int index)
        {
            return voto[index];
        }

        public int getVotoCount() 
        {
            return voto.Count;
        }



    }
}
namespace ClassLibrary1
{
    public class Voti
    {
        protected List<double> voto;

        public Voti()
        {
            voto = new List<double>();
        }

        public void Aggiungi(double v)
        {
            voto.Add(v);
        }


    }
}
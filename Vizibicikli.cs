namespace HelloWorld
{
    internal class Vizibicikli
    {
        //Név;JAzon;EÓra;EPerc;VÓra;Vperc
        public string Nev;
        public string JAzon;
        public int Eora;
        public int Eperc;
        public int Vora;
        public int Vperc;

        public Vizibicikli (string Sor)
        {
            var dbok = Sor.Split(';');

        }
    }
}
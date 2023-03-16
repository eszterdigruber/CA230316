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
            this.Nev = dbok[0];
            this.JAzon = dbok[1];
            this.Eora = int.Parse(dbok[2]);
            this.Eperc = int.Parse(dbok[3]);
            this.Vora = int.Parse(dbok[4]);
            this.Vperc = int.Parse(dbok[5]);
        }
    }
}
namespace ListaDeFilmes
{
    internal class Serie
    {
        private string Titulo;
        private int Ano;
        private int Temporadas;

        //Construtores
        public Serie() { }
        public Serie(string titulo, int ano, int temporadas)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Temporadas = temporadas;
        }

        //get
        public string getTitulo() { return Titulo; }
        public int getAno() { return Ano; }
        public int getTemporadas() { return Temporadas; }


        public override string ToString()
        {
            return "Serie: " + Titulo + " ano: " + Ano + " Temporadas: " + Temporadas;
        }
    }
}

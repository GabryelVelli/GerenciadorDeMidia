using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFilmes
{
    internal class Filme
    {
        private string Titulo;
        private string Genero;
        private int Ano;

        public Filme() { }

        public Filme(string titulo, string Genero, int ano)
        {
            this.Titulo = titulo;
            this.Genero = Genero;
            this.Ano = ano;
        }

        //get
        public string getTitulo() { return Titulo; }
        public string getGenero() { return Genero; }
        public int getAno() { return Ano; }


        public override string ToString()
        {
            return "Filme: " + Titulo + " ano: " + Ano + " Genero: " + Genero;
        }
    }
}

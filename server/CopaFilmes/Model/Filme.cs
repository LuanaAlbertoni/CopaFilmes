using System;

namespace CopaFilmes.Model
{
    public class Filme
    {
        private string id;
        private string titulo;
        private int anoDeLancamento;
        private double nota;


        public Filme() { }

        public Filme(string id, String titulo, int anoDeLancamento, double nota)
        {
            this.id = id;
            this.titulo = titulo;
            this.anoDeLancamento = anoDeLancamento;
            this.nota = nota;

        }

        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int AnoDeLancamento { get => anoDeLancamento; set => anoDeLancamento = value; }
        public double Nota { get => nota; set => nota = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

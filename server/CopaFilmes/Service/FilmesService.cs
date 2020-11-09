using CopaFilmes.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Service
{
    public class FilmesService
    {




        public List<Filme> GetFilmes()
        {
            List<Filme> filmes = new List<Filme>();

            Random rnd = new Random();
            filmes.Add(new Filme("01", "nomedofilme5", 1991, 1));
            filmes.Add(new Filme("02", "nomedofilme1", 1991, 2));
            filmes.Add(new Filme("03", "nomedofilme4", 1991, 3));
            filmes.Add(new Filme("04", "nomedofilme5", 1991, 4));
            filmes.Add(new Filme("05", "nomedofilme6", 1991, 5));
            filmes.Add(new Filme("06", "nomedofilm6e", 1991, 6));
            filmes.Add(new Filme("07", "nomedofilme6", 1991, 7));
            filmes.Add(new Filme("08", "nomedofilme7", 1991, 8));

            filmes.OrderBy(f => f.Titulo);

            return filmes;



        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }


        public List<Filme> GetLastAndFirst(List<Filme> filmes)
        {
            var lastAndFirstFilmes = new List<Filme>();

            var primeiroFilmes = filmes.First();
            var ultimoFilmes = filmes.Last();

            lastAndFirstFilmes.Add(primeiroFilmes);
            lastAndFirstFilmes.Add(ultimoFilmes);


            return lastAndFirstFilmes;

        }

        public void RemoveLastAndFirst(List<Filme> filmes)
        {

            var lastAndFirstFilmes = new List<Filme>();

            var primeiroFilmes = filmes.First();
            var ultimoFilmes = filmes.Last();

            filmes.Remove(primeiroFilmes);
            filmes.Remove(ultimoFilmes);

        }

        public Filme GetWinnerLastAndFirst(List<Filme> filmes)
        {
            var primeiro = filmes.First();
            var ultimo = filmes.Last();

            if (primeiro.Nota < ultimo.Nota)
            {
                return ultimo;
            }
            else if (primeiro.Nota > ultimo.Nota)
            {
                return primeiro;
            }
            else if ((string.Compare(primeiro.Titulo, ultimo.Titulo)) > 0)
            {
                return ultimo;
            }
            else
            {
                return primeiro;
            }

        }

        public List<Filme> GetFirstAndSecond(List<Filme> filmes)
        {
            var firstAndSecondfilmes = new List<Filme>();

            var primeiroFilmes = filmes.First();
            var segundoFilmes = filmes[1];

            firstAndSecondfilmes.Add(primeiroFilmes);
            firstAndSecondfilmes.Add(segundoFilmes);

            return firstAndSecondfilmes;
        }

        public Filme GetWinnerFirstAndSecond(List<Filme> filmes)
        {
            var primeiro = filmes.First();
            var segundo = filmes[1];

            if (primeiro.Nota < segundo.Nota)
            {
                return segundo;
            }
            else if (primeiro.Nota > segundo.Nota)
            {
                return primeiro;
            }
            else if ((string.Compare(primeiro.Titulo, segundo.Titulo)) > 0)
            {
                return segundo;
            }
            else
            {
                return primeiro;
            }

        }

        public void RemoveFirstAndSecond(List<Filme> filmes)
        {
            var firstAndSecondFilmes = new List<Filme>();

            var primeiroFilme = filmes.First();
            var segundoFilme = filmes[1];

            filmes.Remove(primeiroFilme);
            filmes.Remove(segundoFilme);
        }
    }
}

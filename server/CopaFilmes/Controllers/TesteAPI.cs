using CopaFilmes.Model;
using CopaFilmes.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaFilmes.Controllers
{
    [Route("api/public/v1")]
    public class TesteAPI : ControllerBase
    {
        [HttpGet]
        //  [Route("{id}/get")]

 
        public List<Filme> PrimeiraEtapa()
        {

            var filmesService = new FilmesService();

            var todosOsFilmes = filmesService.GetFilmes();

            var filmesVencedores = new List<Filme>();



            foreach (var filme in todosOsFilmes)
            {
                var primeiroEUltimo = filmesService.GetLastAndFirst(todosOsFilmes);

                var vencedorChave = filmesService.GetWinnerLastAndFirst(primeiroEUltimo);

                filmesVencedores.Add(vencedorChave);

                filmesService.RemoveLastAndFirst(todosOsFilmes);
            }

            return filmesVencedores;
        }

        public List<Filme> SegundaEtapa()
        {

            var semiFinalistas = PrimeiraEtapa();

            var filmesSevice = new FilmesService();


            foreach (var filme in semiFinalistas)
            {
                var primeiroESegundo = filmesSevice.GetFirstAndSecond(semiFinalistas);

                var vencedorChave = filmesSevice.GetWinnerFirstAndSecond(primeiroESegundo);

                semiFinalistas.Add(vencedorChave);

                filmesSevice.RemoveFirstAndSecond(semiFinalistas);

            }


            return semiFinalistas;
        }

        public Filme Final()
        {
            var finalistas = SegundaEtapa();

            var filmesSevice = new FilmesService();

            var vencedor = filmesSevice.GetWinnerFirstAndSecond(finalistas);

            return vencedor;
        }


    }
}

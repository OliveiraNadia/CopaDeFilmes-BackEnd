using CopaDeFilmes.Interfaces.Repository;
using CopaDeFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using CopaDeFilmes.Interfaces.Service;

namespace CopaDeFilmes.Repository
{
    public class FilmeRepository : ICampeonatoService
    {
        private const string _api = "http://copadosfilmes.azurewebsites.net/api/filmes";

        public async Task<IEnumerable<FilmeModel>> GetFilmes()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(_api);

            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<FilmeModel>>(data);

            return result;

        }

        public List<Tuple<FilmeModel, FilmeModel>> CriarChaveamento(List<FilmeModel> filmes)
        {
            filmes.OrderBy(f => f.Titulo);

            var filme1 = filmes[0];
            var filme8 = filmes[7];
            var primeiroPar = Tuple.Create(filme1, filme8);

            var filme2 = filmes[1];
            var filme7 = filmes[6];
            var segundoPar = Tuple.Create(filme2, filme7);

            var filme3 = filmes[2];
            var filme6 = filmes[5];
            var terceiroPar = Tuple.Create(filme3, filme6);

            var filme4 = filmes[3];
            var filme5 = filmes[4];
            var quartoPar = Tuple.Create(filme4, filme5);

            var listaChaveamento = new List<Tuple<FilmeModel, FilmeModel>>();
            listaChaveamento.Add(primeiroPar);
            listaChaveamento.Add(segundoPar);
            listaChaveamento.Add(terceiroPar);
            listaChaveamento.Add(quartoPar);

            return listaChaveamento;
        }
        public Tuple<FilmeModel, FilmeModel> Partida(List<Tuple<FilmeModel, FilmeModel>> filmes)
        {
            var maiorNotaPrimeiroPar = filmes[0].Item1.Nota > filmes[0].Item2.Nota ? filmes[0].Item1 : filmes[0].Item2;
            var maiorNotaSegundoPar = filmes[1].Item1.Nota > filmes[1].Item2.Nota ? filmes[1].Item1 : filmes[1].Item2;
            var maiorNotaTerceiroPar = filmes[2].Item1.Nota > filmes[2].Item2.Nota ? filmes[2].Item1 : filmes[2].Item2;
            var maiorNotaQuartoPar = filmes[3].Item1.Nota > filmes[3].Item2.Nota ? filmes[3].Item1 : filmes[3].Item2;

            var filmeVencedorA = maiorNotaPrimeiroPar.Nota > maiorNotaSegundoPar.Nota ? maiorNotaPrimeiroPar : maiorNotaSegundoPar;
            var filmeVencedorB = maiorNotaTerceiroPar.Nota > maiorNotaQuartoPar.Nota ? maiorNotaTerceiroPar : maiorNotaQuartoPar;

            var vencedores = Tuple.Create(filmeVencedorA, filmeVencedorB);
            return vencedores;
        }

        public Tuple<FilmeModel, FilmeModel> ResultadoFinal(Tuple<FilmeModel, FilmeModel> filmes)
        {
            if (filmes.Item1.Nota > filmes.Item2.Nota)
            {
                filmes.Item1.Campeao = true;
            }
            else
            {
                filmes.Item2.Campeao = true;
            }

            return filmes;
        }



    }

}


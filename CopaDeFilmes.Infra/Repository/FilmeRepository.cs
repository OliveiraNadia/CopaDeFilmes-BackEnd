using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CopaDeFilmes.Infra.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private const string _api = "http://copadosfilmes.azurewebsites.net/api/filmes";

        public async ValueTask<List<Filme>> ListarFilmes()
        {
            using (HttpClient client = new HttpClient())
            {
                List<Filme> filmes = null;
                HttpRequestMessage response = await client.GetAsync(_api);

                if (response.IsSuccessStatusCode)
                {
                    filmes = JsonConvert.DeserializeObject<List<Filme>>(await response.Content.ReadAsStringAsync());
                }

                return filmes;
            }

        }
    }
}

using CopaDeFilmes.Domain.Interfaces.Services;
using CopaDeFilmes.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CopaDeFilmes.Controllers
{
    public class CampeonatoController : Controller
    {
        private readonly ICampeonatoService _campeonatoService;
        public CampeonatoController(ICampeonatoService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> GerarCampeonato([FromBody]string[] Idfilmes)
        {
            try
            {
                Campeonato campeonato = await _campeonatoService.GerarCampeonato(Idfilmes);

                return Ok(campeonato);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}

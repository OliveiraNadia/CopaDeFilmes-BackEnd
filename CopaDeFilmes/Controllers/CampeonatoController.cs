using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDeFilmes.Interfaces.Repository;
using CopaDeFilmes.Interfaces.Service;
using CopaDeFilmes.Interfaces_Domain;
using CopaDeFilmes.Models;
using CopaDeFilmes.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CopaDeFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonatoController : ControllerBase
    {
        private readonly ICampeonatoApplicationService _campeonatoApllicationService;
        public CampeonatoController(ICampeonatoApplicationService campeonatoService)
        {
            _campeonatoApllicationService = campeonatoService;

        }

        [HttpGet]
        [Route("filmes")]
        public async Task<ActionResult> GetFilmes()
        {
            try
            {
                var filmes = await _campeonatoApllicationService.GetFilmes();

                return Ok(filmes);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult>GerarCampeonato([FromBody]IEnumerable<FilmeViewModel> filmes)
        {
            try
            {
                var resultado = _campeonatoApllicationService.GerarCampeonato(filmes);

                return Ok(filmes);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

     
    }
}

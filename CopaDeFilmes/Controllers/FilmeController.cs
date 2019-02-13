using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CopaDeFilmes.Domain.Interfaces.Services;
using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Models;

namespace CopaDeFilmes.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    public class FilmeController : Controller
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
        [HttpGet]
        public async ValueTask<IActionResult> Obter()
        {
            try
            {
                var filmes = await _filmeRepository.ListaFilmes();

                return Ok(filmes);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }
    }
}

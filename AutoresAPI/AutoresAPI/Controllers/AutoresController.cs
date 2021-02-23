using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoresAPI.Core.Business;
using AutoresAPI.Core.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorService _autorService;
        private readonly ILibroService _libroService;

        public AutoresController(IAutorService autorService, ILibroService libroService)
        {
            _autorService = autorService;
            _libroService = libroService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autor>>> Obtener()
        {
            var data = await _autorService.Listado();
            if (data == default)
                return NotFound();

            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Autor>>> Obtener(int Id)
        {
            var data = await _autorService.ObtenerPorId(Id);
            if (data == default)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<Autor>> GuardarAsync([FromBody] Autor autor)
        {
            var data = await _autorService.Guardar(autor);
            return Ok(data);
        }
    }
}

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
    public class LibrosController : ControllerBase
    {
        private readonly ILibroService _service;

        public LibrosController(ILibroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> Obtener()
        {
            var data = await _service.Listado();
            if (data == default)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Libro>>> Registrar([FromBody] Libro libro)
        {
            await _service.Guardar(libro);
            return Ok();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Libro>>> Obtener(int Id)
        {
            var data = await _service.ObtenerPorId(Id);
            if (data == default)
                return NotFound();

            return Ok(data);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<IEnumerable<Libro>>> Actualizar(int Id, [FromBody] Libro libro)
        {
            var original = await _service.ObtenerPorId(Id);
            if (original == default)
                return NotFound();

            await _service.Actualizar(original, libro);
            return Ok();
        }
    }
}

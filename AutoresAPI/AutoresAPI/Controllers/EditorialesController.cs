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
    public class EditorialesController : ControllerBase
    {
        private readonly IEditorialService _service;

        public EditorialesController(IEditorialService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Editorial>> GuardarEditorialAsync([FromBody] Editorial editorial)
        {
            var data = await _service.Guardar(editorial);
            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Editorial>>> Obtener()
        {
            var data = await _service.Listado();
            if (data == default)
                return NotFound();

            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Editorial>>> Obtener(int Id)
        {
            var data = await _service.ObtenerPorId(Id);
            if (data == default)
                return NotFound();

            return Ok(data);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<Editorial>> ActualizarEditorialAsync(int Id, [FromBody] Editorial editorial)
        {
            var original = await _service.ObtenerPorId(Id);
            if (original == default)
                return NotFound();

            await _service.Actualizar(original, editorial);
            return Ok();
        }

        [HttpGet("{Id}/autor")]
        public async Task<ActionResult<IEnumerable<Autor>>> ObtenerAutoresPorEditorialAsync(int Id)
        {
            var original = await _service.ObtenerPorId(Id);
            if (original == default)
                return NotFound();

            var data = await _service.ObtenerAutoresPorEditorial(Id);
            return Ok(data);
        }
    }
}

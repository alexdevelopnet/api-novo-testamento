using Microsoft.AspNetCore.Mvc;
using ApiNovoTestamento.Models;
using api_novo_testamento.Interfaces;
using System.Threading.Tasks;
using api_novo_testamento.Dtos;


namespace ApiNovoTestamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApostolosController : ControllerBase
    {
        private readonly IApostoloService _service;

        public ApostolosController(IApostoloService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApostoloResponse>>> GetApostolos()
        {
            var apostolos = await _service.GetAll();
            return Ok(apostolos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApostoloResponse>> GetApostolo(int id)
        {
            var apostolo = await _service.GetById(id);
            if (apostolo == null)
            {
                return NotFound();
            }
            return Ok(apostolo);
        }

        [HttpPost]
        public ActionResult<Apostolo> AddApostolo(ApostoloRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return CreatedAtAction(nameof(GetApostolo), new { id = request.Nome }, request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApostolo(int id, [FromBody] ApostoloRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _service.Update(id, request);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApostolo(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}

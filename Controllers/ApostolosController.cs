using Microsoft.AspNetCore.Mvc;
using ApiNovoTestamento.Models;
 

namespace ApiNovoTestamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApostolosController : ControllerBase
    {
        private static List<Apostolo> apostolos = new List<Apostolo>
        {
            new Apostolo { Id = 1, Nome = "Pedro" },
            new Apostolo { Id = 2, Nome = "Tiago, filho de Zebedeu" },
            new Apostolo { Id = 3, Nome = "João" },
            new Apostolo { Id = 4, Nome = "André" },
            new Apostolo { Id = 5, Nome = "Filipe" },
            new Apostolo { Id = 6, Nome = "Bartolomeu" },
            new Apostolo { Id = 7, Nome = "Mateus" },
            new Apostolo { Id = 8, Nome = "Tomé" },
            new Apostolo { Id = 9, Nome = "Tiago, filho de Alfeu" },
            new Apostolo { Id = 10, Nome = "Tadeu (ou Judas, filho de Tiago)" },
            new Apostolo { Id = 11, Nome = "Simão, o Zelote" },
            new Apostolo { Id = 12, Nome = "Judas Iscariotes" }
        };

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apostolo>>> GetApostolos()
        {
            return Ok(apostolos);
        }

        [HttpGet("{id}")]
        public ActionResult<Apostolo> GetApostolo(int id)
        {
            var apostolo = apostolos.FirstOrDefault(a => a.Id == id);
            if (apostolo == null)
            {
                return NotFound();
            }
            return Ok(apostolo);
        }

        [HttpPost]
        public ActionResult<Apostolo> AddApostolo(Apostolo novoApostolo)
        {
            apostolos.Add(novoApostolo);
            return CreatedAtAction(nameof(GetApostolo), new { id = novoApostolo.Id }, novoApostolo);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateApostolo(int id, Apostolo atualizadoApostolo)
        {
            var apostolo = apostolos.FirstOrDefault(a => a.Id == id);
            if (apostolo == null)
            {
                return NotFound();
            }

            apostolo.Nome = atualizadoApostolo.Nome;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteApostolo(int id)
        {
            var apostolo = apostolos.FirstOrDefault(a => a.Id == id);
            if (apostolo == null)
            {
                return NotFound();
            }

            apostolos.Remove(apostolo);
            return NoContent();
        }
    }
}

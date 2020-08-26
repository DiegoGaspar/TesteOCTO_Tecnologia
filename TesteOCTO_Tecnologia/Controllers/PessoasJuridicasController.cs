using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudOCTOTecnologia.Models;
using TesteOCTO_Tecnologia.Data;

namespace TesteOCTO_Tecnologia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasJuridicasController : ControllerBase
    {
        private readonly TesteOCTO_TecnologiaContext _context;

        public PessoasJuridicasController(TesteOCTO_TecnologiaContext context)
        {
            _context = context;
        }

        // GET: api/PessoasJuridicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaJuridica>>> GetPessoaJuridica()
        {
            return await _context.PessoaJuridica.ToListAsync();
        }

        // GET: api/PessoasJuridicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaJuridica>> GetPessoaJuridica(int id)
        {
            var pessoaJuridica = await _context.PessoaJuridica.FindAsync(id);

            if (pessoaJuridica == null)
            {
                return NotFound();
            }

            return pessoaJuridica;
        }

        // PUT: api/PessoasJuridicas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoaJuridica(int id, PessoaJuridica pessoaJuridica)
        {
            if (id != pessoaJuridica.ID)
            {
                return BadRequest();
            }

            _context.Entry(pessoaJuridica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaJuridicaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PessoasJuridicas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PessoaJuridica>> PostPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            _context.PessoaJuridica.Add(pessoaJuridica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoaJuridica", new { id = pessoaJuridica.ID }, pessoaJuridica);
        }

        // DELETE: api/PessoasJuridicas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PessoaJuridica>> DeletePessoaJuridica(int id)
        {
            var pessoaJuridica = await _context.PessoaJuridica.FindAsync(id);
            if (pessoaJuridica == null)
            {
                return NotFound();
            }

            _context.PessoaJuridica.Remove(pessoaJuridica);
            await _context.SaveChangesAsync();

            return pessoaJuridica;
        }

        private bool PessoaJuridicaExists(int id)
        {
            return _context.PessoaJuridica.Any(e => e.ID == id);
        }
    }
}

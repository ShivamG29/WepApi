using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dsc_Core_WebAPI_YT.Models;

namespace Dsc_Core_WebAPI_YT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblDscsController : ControllerBase
    {
        private readonly DscContext _context;

        public TblDscsController(DscContext context)
        {
            _context = context;
        }

        // GET: api/TblDscs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblDsc>>> GetTblDscs()
        {
          if (_context.TblDscs == null)
          {
              return NotFound();
          }
            return Ok(await _context.TblDscs.ToListAsync());
        }

        // GET: api/TblDscs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblDsc>> GetTblDsc(int id)
        {
          if (_context.TblDscs == null)
          {
              return NotFound();
          }
            var tblDsc = await _context.TblDscs.FindAsync(id);

            if (tblDsc == null)
            {
                return NotFound();
            }

            return Ok(tblDsc);
        }

        // PUT: api/TblDscs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblDsc(int id, TblDsc tblDsc)
        {
            if (id != tblDsc.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblDsc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblDscExists(id))
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

        // POST: api/TblDscs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblDsc>> PostTblDsc(TblDsc tblDsc)
        {
          if (_context.TblDscs == null)
          {
              return Problem("Entity set 'DscContext.TblDscs'  is null.");
          }

            _context.Add(tblDsc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblDsc", new { id = tblDsc.Id }, tblDsc);
        }

        // DELETE: api/TblDscs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblDsc(int id)
        {
            if (_context.TblDscs == null)
            {
                return NotFound();
            }
            var tblDsc = await _context.TblDscs.FindAsync(id);
            if (tblDsc == null)
            {
                return NotFound();
            }

            _context.TblDscs.Remove(tblDsc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblDscExists(int id)
        {
            return (_context.TblDscs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

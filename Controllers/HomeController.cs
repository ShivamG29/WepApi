using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dsc_Core_WebAPI_YT.Models;

namespace Dsc_Core_WebAPI_YT.Controllers
{
    public class HomeController : Controller
    {
        private readonly DscContext _context;

        public HomeController(DscContext context)
        {
            _context = context;
        }

        // GET: Home
        public async Task<IActionResult> Index()
        {
              return _context.TblDscs != null ? 
                          View(await _context.TblDscs.ToListAsync()) :
                          Problem("Entity set 'DscContext.TblDscs'  is null.");
        }

        // GET: Home/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblDscs == null)
            {
                return NotFound();
            }

            var tblDsc = await _context.TblDscs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblDsc == null)
            {
                return NotFound();
            }

            return View(tblDsc);
        }

        // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CertificateClass,CertificateTypes,CertificateValidity,PanNo,PersonName,EmailId,MobileNo,Pincode,City,State,Address,Gender,DateOfBirth,EkycId,EkycPin,AadharLast4Digits,DownloadKey,AddressProof,IdProof,UploadPhoto,Remark")] TblDsc tblDsc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblDsc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblDsc);
        }

        // GET: Home/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblDscs == null)
            {
                return NotFound();
            }

            var tblDsc = await _context.TblDscs.FindAsync(id);
            if (tblDsc == null)
            {
                return NotFound();
            }
            return View(tblDsc);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CertificateClass,CertificateTypes,CertificateValidity,PanNo,PersonName,EmailId,MobileNo,Pincode,City,State,Address,Gender,DateOfBirth,EkycId,EkycPin,AadharLast4Digits,DownloadKey,AddressProof,IdProof,UploadPhoto,Remark")] TblDsc tblDsc)
        {
            if (id != tblDsc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblDsc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblDscExists(tblDsc.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tblDsc);
        }

        // GET: Home/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblDscs == null)
            {
                return NotFound();
            }

            var tblDsc = await _context.TblDscs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblDsc == null)
            {
                return NotFound();
            }

            return View(tblDsc);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblDscs == null)
            {
                return Problem("Entity set 'DscContext.TblDscs'  is null.");
            }
            var tblDsc = await _context.TblDscs.FindAsync(id);
            if (tblDsc != null)
            {
                _context.TblDscs.Remove(tblDsc);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblDscExists(int id)
        {
          return (_context.TblDscs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

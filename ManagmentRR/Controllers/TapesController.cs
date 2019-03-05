using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagmentRR.Models;
using ManagmentRR.Services;

namespace ManagmentRR.Controllers
{
    public class TapesController : Controller
    {
        private readonly ManagmentRRContext _context;

        private readonly EmpresaServices _empresaServices;

        public TapesController(EmpresaServices empresaServices)
        {
            _empresaServices = empresaServices;
        }

        public TapesController(ManagmentRRContext context)
        {
            _context = context;
        }

        // GET: Tapes
        public async Task<IActionResult> Index()
        {
            var list = _empresaServices.FindEmpresa();
            return View(await _context.Tape.ToListAsync());
            
        }

        // GET: Tapes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tape = await _context.Tape
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tape == null)
            {
                return NotFound();
            }

            return View(tape);
        }

        // GET: Tapes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tapes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Tape tape)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tape);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tape);
        }

        // GET: Tapes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tape = await _context.Tape.FindAsync(id);
            if (tape == null)
            {
                return NotFound();
            }
            return View(tape);
        }

        // POST: Tapes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Tape tape)
        {
            if (id != tape.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tape);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TapeExists(tape.Id))
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
            return View(tape);
        }

        // GET: Tapes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tape = await _context.Tape
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tape == null)
            {
                return NotFound();
            }

            return View(tape);
        }

        // POST: Tapes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tape = await _context.Tape.FindAsync(id);
            _context.Tape.Remove(tape);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TapeExists(int id)
        {
            return _context.Tape.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagmentRR.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ManagmentRR.Models
{
    public class TrocaTapesController : Controller
    {
        private readonly ManagmentRRContext _context;
        private readonly Services.EmpresaServices _empresaService;
        private readonly Services.TapeService _tapeService;

      

        public TrocaTapesController(ManagmentRRContext context, Services.EmpresaServices empresaService, Services.TapeService tapeService)
        {
            _context = context;
            _empresaService = empresaService;
            _tapeService = tapeService;
        }
        // GET: TrocaTapes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrocaTape.ToListAsync());
        }

        // GET: TrocaTapes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trocaTape = await _context.TrocaTape
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trocaTape == null)
            {
                return NotFound();
            }

            return View(trocaTape);
        }

        // GET: TrocaTapes/Create
        public IActionResult Create()
        {
            var empresas = _empresaService.FindEmpresa();
            var tapes = _tapeService.FindTapes();
            var viewModel = new TapeCreateViewModel { Empresas = empresas, Tapes = tapes };
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Id"); 
            ViewData["TapeId"] = new SelectList(_context.Tape, "Id", "Id");
            return View(viewModel);
           
        }

        // POST: TrocaTapes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicio,DataFim")] TrocaTape trocaTape)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trocaTape);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trocaTape);
        }

        // GET: TrocaTapes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trocaTape = await _context.TrocaTape.FindAsync(id);
            if (trocaTape == null)
            {
                return NotFound();
            }
            return View(trocaTape);
        }

        // POST: TrocaTapes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicio,DataFim")] TrocaTape trocaTape)
        {
            if (id != trocaTape.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trocaTape);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrocaTapeExists(trocaTape.Id))
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
            return View(trocaTape);
        }

        // GET: TrocaTapes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trocaTape = await _context.TrocaTape
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trocaTape == null)
            {
                return NotFound();
            }

            return View(trocaTape);
        }

        // POST: TrocaTapes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trocaTape = await _context.TrocaTape.FindAsync(id);
            _context.TrocaTape.Remove(trocaTape);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrocaTapeExists(int id)
        {
            return _context.TrocaTape.Any(e => e.Id == id);
        }
    }
}

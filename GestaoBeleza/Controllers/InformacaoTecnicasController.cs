using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoBeleza.Data;
using GestaoBeleza.Models;

namespace GestaoBeleza.Controllers
{
    public class InformacaoTecnicasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InformacaoTecnicasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InformacaoTecnicas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.InformacaoTecnica.Include(i => i.HistoricoQuimico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: InformacaoTecnicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informacaoTecnica = await _context.InformacaoTecnica
                .Include(i => i.HistoricoQuimico)
                .FirstOrDefaultAsync(m => m.InformacaoTecnicaId == id);
            if (informacaoTecnica == null)
            {
                return NotFound();
            }

            return View(informacaoTecnica);
        }

        // GET: InformacaoTecnicas/Create
        public IActionResult Create()
        {
            ViewData["HistoricoQuimicoId"] = new SelectList(_context.HistoricoQuimico, "HistoricoQuimicoId", "HistoricoQuimicoId");
            return View();
        }

        // POST: InformacaoTecnicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InformacaoTecnicaId,TipoDeCabelo,Textura,Densidade,Porosidade,Elasticidade,CondicaoCouroCabeludo,HistoricoQuimicoId")] InformacaoTecnica informacaoTecnica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(informacaoTecnica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HistoricoQuimicoId"] = new SelectList(_context.HistoricoQuimico, "HistoricoQuimicoId", "HistoricoQuimicoId", informacaoTecnica.HistoricoQuimicoId);
            return View(informacaoTecnica);
        }

        // GET: InformacaoTecnicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informacaoTecnica = await _context.InformacaoTecnica.FindAsync(id);
            if (informacaoTecnica == null)
            {
                return NotFound();
            }
            ViewData["HistoricoQuimicoId"] = new SelectList(_context.HistoricoQuimico, "HistoricoQuimicoId", "HistoricoQuimicoId", informacaoTecnica.HistoricoQuimicoId);
            return View(informacaoTecnica);
        }

        // POST: InformacaoTecnicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InformacaoTecnicaId,TipoDeCabelo,Textura,Densidade,Porosidade,Elasticidade,CondicaoCouroCabeludo,HistoricoQuimicoId")] InformacaoTecnica informacaoTecnica)
        {
            if (id != informacaoTecnica.InformacaoTecnicaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(informacaoTecnica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InformacaoTecnicaExists(informacaoTecnica.InformacaoTecnicaId))
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
            ViewData["HistoricoQuimicoId"] = new SelectList(_context.HistoricoQuimico, "HistoricoQuimicoId", "HistoricoQuimicoId", informacaoTecnica.HistoricoQuimicoId);
            return View(informacaoTecnica);
        }

        // GET: InformacaoTecnicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informacaoTecnica = await _context.InformacaoTecnica
                .Include(i => i.HistoricoQuimico)
                .FirstOrDefaultAsync(m => m.InformacaoTecnicaId == id);
            if (informacaoTecnica == null)
            {
                return NotFound();
            }

            return View(informacaoTecnica);
        }

        // POST: InformacaoTecnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var informacaoTecnica = await _context.InformacaoTecnica.FindAsync(id);
            _context.InformacaoTecnica.Remove(informacaoTecnica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InformacaoTecnicaExists(int id)
        {
            return _context.InformacaoTecnica.Any(e => e.InformacaoTecnicaId == id);
        }
    }
}

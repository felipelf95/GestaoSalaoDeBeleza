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
    public class HistoricoQuimicoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoricoQuimicoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HistoricoQuimicoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricoQuimico.ToListAsync());
        }

        // GET: HistoricoQuimicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoQuimico = await _context.HistoricoQuimico
                .FirstOrDefaultAsync(m => m.HistoricoQuimicoId == id);
            if (historicoQuimico == null)
            {
                return NotFound();
            }

            return View(historicoQuimico);
        }

        // GET: HistoricoQuimicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoQuimicoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HistoricoQuimicoId,DataUltimoServicoRealizado,EspecificacoesDosServicos,RespectivosProfissionais,QuimicaUtilizada")] HistoricoQuimico historicoQuimico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historicoQuimico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoQuimico);
        }

        // GET: HistoricoQuimicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoQuimico = await _context.HistoricoQuimico.FindAsync(id);
            if (historicoQuimico == null)
            {
                return NotFound();
            }
            return View(historicoQuimico);
        }

        // POST: HistoricoQuimicoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HistoricoQuimicoId,DataUltimoServicoRealizado,EspecificacoesDosServicos,RespectivosProfissionais,QuimicaUtilizada")] HistoricoQuimico historicoQuimico)
        {
            if (id != historicoQuimico.HistoricoQuimicoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoQuimico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoQuimicoExists(historicoQuimico.HistoricoQuimicoId))
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
            return View(historicoQuimico);
        }

        // GET: HistoricoQuimicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoQuimico = await _context.HistoricoQuimico
                .FirstOrDefaultAsync(m => m.HistoricoQuimicoId == id);
            if (historicoQuimico == null)
            {
                return NotFound();
            }

            return View(historicoQuimico);
        }

        // POST: HistoricoQuimicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historicoQuimico = await _context.HistoricoQuimico.FindAsync(id);
            _context.HistoricoQuimico.Remove(historicoQuimico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoQuimicoExists(int id)
        {
            return _context.HistoricoQuimico.Any(e => e.HistoricoQuimicoId == id);
        }
    }
}

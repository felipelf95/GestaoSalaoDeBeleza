using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoBeleza.Data;
using GestaoBeleza.Models.Cliente;

namespace GestaoBeleza.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cliente.Include(c => c.InformacaoTecnica);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.InformacaoTecnica)
                .FirstOrDefaultAsync(m => m.EnderecoId == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["InformacaoTecnicaId"] = new SelectList(_context.InformacaoTecnica, "InformacaoTecnicaId", "InformacaoTecnicaId");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClienteId,Instagram,Facebook,InformacaoTecnicaId,Nome,Sexo,DataNascimento,Telefone,Email,Cpf,EnderecoId,Cep,Logradouro,Bairro,Cidade,Estado,NumeroCasa,Complemento")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InformacaoTecnicaId"] = new SelectList(_context.InformacaoTecnica, "InformacaoTecnicaId", "InformacaoTecnicaId", cliente.InformacaoTecnicaId);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["InformacaoTecnicaId"] = new SelectList(_context.InformacaoTecnica, "InformacaoTecnicaId", "InformacaoTecnicaId", cliente.InformacaoTecnicaId);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteId,Instagram,Facebook,InformacaoTecnicaId,Nome,Sexo,DataNascimento,Telefone,Email,Cpf,EnderecoId,Cep,Logradouro,Bairro,Cidade,Estado,NumeroCasa,Complemento")] Cliente cliente)
        {
            if (id != cliente.EnderecoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.EnderecoId))
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
            ViewData["InformacaoTecnicaId"] = new SelectList(_context.InformacaoTecnica, "InformacaoTecnicaId", "InformacaoTecnicaId", cliente.InformacaoTecnicaId);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.InformacaoTecnica)
                .FirstOrDefaultAsync(m => m.EnderecoId == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.EnderecoId == id);
        }
    }
}

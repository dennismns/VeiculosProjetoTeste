using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeiculosProjetoTeste.Dados;
using VeiculosProjetoTeste.Models;

namespace VeiculosProjetoTeste.Controllers
{
    public class AcessoriosController : Controller
    {
        private readonly DadosContext _context;

        public AcessoriosController(DadosContext context)
        {
            _context = context;
        }

        // GET: Acessorios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Acessorios.ToListAsync());
        }

        // GET: Acessorios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acessorio = await _context.Acessorios
                .SingleOrDefaultAsync(m => m.AcessorioId == id);
            if (acessorio == null)
            {
                return NotFound();
            }

            return View(acessorio);
        }

        // GET: Acessorios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acessorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AcessorioId,Nome")] Acessorio acessorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acessorio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acessorio);
        }

        // GET: Acessorios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acessorio = await _context.Acessorios.SingleOrDefaultAsync(m => m.AcessorioId == id);
            if (acessorio == null)
            {
                return NotFound();
            }
            return View(acessorio);
        }

        // POST: Acessorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AcessorioId,Nome")] Acessorio acessorio)
        {
            if (id != acessorio.AcessorioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acessorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcessorioExists(acessorio.AcessorioId))
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
            return View(acessorio);
        }

        // GET: Acessorios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acessorio = await _context.Acessorios
                .SingleOrDefaultAsync(m => m.AcessorioId == id);
            if (acessorio == null)
            {
                return NotFound();
            }

            return View(acessorio);
        }

        // POST: Acessorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acessorio = await _context.Acessorios.SingleOrDefaultAsync(m => m.AcessorioId == id);
            _context.Acessorios.Remove(acessorio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcessorioExists(int id)
        {
            return _context.Acessorios.Any(e => e.AcessorioId == id);
        }
    }
}

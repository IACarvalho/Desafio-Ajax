#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroDeEmrpesas.Data;
using CadastroDeEmrpesas.Models;

namespace CadastroDeEmrpesas.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpresasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Empresas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Emrpesas.ToListAsync());
        }

        // GET: Empresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emrpesa = await _context.Emrpesas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emrpesa == null)
            {
                return NotFound();
            }

            return View(emrpesa);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create( Emrpesa emrpesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emrpesa);
                await _context.SaveChangesAsync();
                TempData["success"] = "Empresa cadastrada com sucesso";
                return RedirectToAction(nameof(Index));
            }
            return View(emrpesa);
        }

        // GET: Empresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emrpesa = await _context.Emrpesas.FindAsync(id);
            if (emrpesa == null)
            {
                return NotFound();
            }
            return View(emrpesa);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, Emrpesa emrpesa)
        {
            if (id != emrpesa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emrpesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmrpesaExists(emrpesa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["error"] = $"Occoreu um erro, entre em contato com o suporte.";
                        throw;
                    }
                }
                TempData["success"] = "Empresa atualizada com sucesso";
                return RedirectToAction(nameof(Index));
            }
            return View(emrpesa);
        }

        // GET: Empresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emrpesa = await _context.Emrpesas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emrpesa == null)
            {
                return NotFound();
            }

            return View(emrpesa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emrpesa = await _context.Emrpesas.FindAsync(id);
            _context.Emrpesas.Remove(emrpesa);
            await _context.SaveChangesAsync();
            TempData["success"] = "Empresa excluída com sucesso";
            return RedirectToAction(nameof(Index));
        }

        private bool EmrpesaExists(int id)
        {
            return _context.Emrpesas.Any(e => e.Id == id);
        }
    }
}

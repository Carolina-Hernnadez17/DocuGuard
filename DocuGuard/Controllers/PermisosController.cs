using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DocuGuard.Models;

namespace DocuGuard.Controllers
{
    public class PermisosController : Controller
    {
        private readonly DocuGuardContext _context;

        public PermisosController(DocuGuardContext context)
        {
            _context = context;
        }

        // GET: Permisos
        public async Task<IActionResult> Index()
        {
            return View(await _context.permisos.ToListAsync());
        }

        // GET: Permisos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permisos = await _context.permisos
                .FirstOrDefaultAsync(m => m.id_permisos == id);
            if (permisos == null)
            {
                return NotFound();
            }

            return View(permisos);
        }

        // GET: Permisos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Permisos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_permisos,id_documentos,id_usuario,nivel_acceso")] permisos permisos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(permisos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(permisos);
        }

        // GET: Permisos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permisos = await _context.permisos.FindAsync(id);
            if (permisos == null)
            {
                return NotFound();
            }
            return View(permisos);
        }

        // POST: Permisos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_permisos,id_documentos,id_usuario,nivel_acceso")] permisos permisos)
        {
            if (id != permisos.id_permisos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(permisos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!permisosExists(permisos.id_permisos))
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
            return View(permisos);
        }

        // GET: Permisos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permisos = await _context.permisos
                .FirstOrDefaultAsync(m => m.id_permisos == id);
            if (permisos == null)
            {
                return NotFound();
            }

            return View(permisos);
        }

        // POST: Permisos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var permisos = await _context.permisos.FindAsync(id);
            if (permisos != null)
            {
                _context.permisos.Remove(permisos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool permisosExists(int id)
        {
            return _context.permisos.Any(e => e.id_permisos == id);
        }
    }
}

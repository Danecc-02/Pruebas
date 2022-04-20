using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroEventos.Data;
using RegistroEventos.Models;

namespace RegistroEventos.Controllers
{
    public class Tipo_capituloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Tipo_capituloController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tipo_capitulo
        public async Task<IActionResult> Index()
        {
            return View(await _context.tipo_Capitulos.ToListAsync());
        }

        // GET: Tipo_capitulo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo_capitulo = await _context.tipo_Capitulos
                .FirstOrDefaultAsync(m => m.id_tipo_capitulo == id);
            if (tipo_capitulo == null)
            {
                return NotFound();
            }

            return View(tipo_capitulo);
        }

        // GET: Tipo_capitulo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipo_capitulo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_tipo_capitulo,nombre_tipo_capitulo")] Tipo_capitulo tipo_capitulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipo_capitulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipo_capitulo);
        }

        // GET: Tipo_capitulo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo_capitulo = await _context.tipo_Capitulos.FindAsync(id);
            if (tipo_capitulo == null)
            {
                return NotFound();
            }
            return View(tipo_capitulo);
        }

        // POST: Tipo_capitulo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_tipo_capitulo,nombre_tipo_capitulo")] Tipo_capitulo tipo_capitulo)
        {
            if (id != tipo_capitulo.id_tipo_capitulo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipo_capitulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tipo_capituloExists(tipo_capitulo.id_tipo_capitulo))
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
            return View(tipo_capitulo);
        }

        // GET: Tipo_capitulo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo_capitulo = await _context.tipo_Capitulos
                .FirstOrDefaultAsync(m => m.id_tipo_capitulo == id);
            if (tipo_capitulo == null)
            {
                return NotFound();
            }

            return View(tipo_capitulo);
        }

        // POST: Tipo_capitulo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipo_capitulo = await _context.tipo_Capitulos.FindAsync(id);
            _context.tipo_Capitulos.Remove(tipo_capitulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tipo_capituloExists(int id)
        {
            return _context.tipo_Capitulos.Any(e => e.id_tipo_capitulo == id);
        }
    }
}

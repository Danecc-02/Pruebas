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
    public class CapituloesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CapituloesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Capituloes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.capitulos.Include(c => c.Tipo_capitulo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Capituloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capitulo = await _context.capitulos
                .Include(c => c.Tipo_capitulo)
                .FirstOrDefaultAsync(m => m.id_capitulo == id);
            if (capitulo == null)
            {
                return NotFound();
            }

            return View(capitulo);
        }

        // GET: Capituloes/Create
        public IActionResult Create()
        {
            ViewData["id_tipo_capitulo"] = new SelectList(_context.tipo_Capitulos, "id_tipo_capitulo", "nombre_tipo_capitulo");
            return View();
        }

        // POST: Capituloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_capitulo,nombre_capitulo,lugar_capitulo,id_tipo_capitulo")] Capitulo capitulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(capitulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["id_tipo_capitulo"] = new SelectList(_context.tipo_Capitulos, "id_tipo_capitulo", "nombre_tipo_capitulo", capitulo.id_tipo_capitulo);
            return View(capitulo);
        }

        // GET: Capituloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capitulo = await _context.capitulos.FindAsync(id);
            if (capitulo == null)
            {
                return NotFound();
            }
            ViewData["id_tipo_capitulo"] = new SelectList(_context.tipo_Capitulos, "id_tipo_capitulo", "nombre_tipo_capitulo", capitulo.id_tipo_capitulo);
            return View(capitulo);
        }

        // POST: Capituloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_capitulo,nombre_capitulo,lugar_capitulo,id_tipo_capitulo")] Capitulo capitulo)
        {
            if (id != capitulo.id_capitulo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(capitulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CapituloExists(capitulo.id_capitulo))
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
            ViewData["id_tipo_capitulo"] = new SelectList(_context.tipo_Capitulos, "id_tipo_capitulo", "nombre_tipo_capitulo", capitulo.id_tipo_capitulo);
            return View(capitulo);
        }

        // GET: Capituloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capitulo = await _context.capitulos
                .Include(c => c.Tipo_capitulo)
                .FirstOrDefaultAsync(m => m.id_capitulo == id);
            if (capitulo == null)
            {
                return NotFound();
            }

            return View(capitulo);
        }

        // POST: Capituloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var capitulo = await _context.capitulos.FindAsync(id);
            _context.capitulos.Remove(capitulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CapituloExists(int id)
        {
            return _context.capitulos.Any(e => e.id_capitulo == id);
        }
    }
}

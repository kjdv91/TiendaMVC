using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;
        //base de datos

        public CategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }
        //inicializo en el constructor el context

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            IEnumerable<Categoria> lista = _context.Category;
              return _context.Category != null ? 
                          View(await _context.Category.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Category'  is null.");
            return View(lista);

        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var categoria = await _context.Category
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCategoria")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoria);  /*anade categoria q recibe de la vista*/
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var categoria = await _context.Category.FindAsync(id); //validaciones
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

       
        // POST: Categorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //El post Actualiza la informacion
        public async Task<IActionResult> Edit(long id, [Bind("IdCategoria")] Categoria categoria)
        {
            if (id != categoria.IdCategoria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoria); //Actualiza la categoria
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaExists(categoria.IdCategoria))
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
            return View(categoria);
        }


        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var categoria = await _context.Category
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }


        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Category == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Category'  is null.");
            }
            var categoria = await _context.Category.FindAsync(id);
            if (categoria != null)
            {
                _context.Category.Remove(categoria);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaExists(long id)
        {
          return (_context.Category?.Any(e => e.IdCategoria == id)).GetValueOrDefault();
        }
    }
}

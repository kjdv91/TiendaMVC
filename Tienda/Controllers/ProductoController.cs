using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _db;  //llamo al db context

        public ProductoController(ApplicationDbContext db)
        {
            _db = db;  //inicializo
        }

        public IActionResult Index()
        {
            IEnumerable<Producto> lista = _db.Producto.Include(c=> c.Categoria)
                .Include(t=> t.TipoAplication);  //datos relacionados y poder llamarlos
            
            
            return View(lista);  //devuelve toda la lista de productos
        }
        //get 
        public IActionResult Upsert(long? Id)

        {
            IEnumerable<SelectListItem> categoriaDropDown = _db.Category.Select(c => new SelectListItem
            {
                Text = c.NombreCategoria,
                Value = c.IdCategoria.ToString()
            });

            ViewBag.categoriaDropDown = categoriaDropDown;
            Producto producto = new Producto();
            if (Id == null)
            {
                //Crear un nuevo producto
                return View(producto);
            }
            else
            {
                producto = _db.Producto.Find(Id);
                if(producto == null)
                {
                    return NotFound();

                }
                return View(producto);
            }

        }
    }
}

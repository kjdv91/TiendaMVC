using Microsoft.AspNetCore.Mvc;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class TipoAplicationController : Controller
    {
        private readonly ApplicationDbContext _context;
        //base de datos

        public TipoAplicationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<TipoAplication> lista = _context.TipoAplication;
     
        //
            return View(lista);
        }


        //Get Edit
        public IActionResult Edit(long? Id)
        {
            if (Id == null )
            {
                return NotFound();

            }
            var obj = _context.TipoAplication.Find(Id); //busca un objeto y devuelve ese objeto a la vista
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoAplication tipo)
        {
            if (ModelState.IsValid)
            {
                _context.TipoAplication.Update(tipo);  //actualiza 
                _context.SaveChanges(); //guarda la edicion
                return RedirectToAction(nameof(Index)); //retorna al index
            }

            return View(tipo);

        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoAplication tipo)
        {
            if (ModelState.IsValid)
            {
                _context.TipoAplication.Add(tipo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(tipo);
            }
   }

        public IActionResult Delete(long? Id)
        {
            if (Id == null)
            {
                return NotFound();

            }
            var obj = _context.TipoAplication.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(TipoAplication tipo)
        {
            if (tipo ==null)
            {
                return NotFound();
            }

            _context.TipoAplication.Remove(tipo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}

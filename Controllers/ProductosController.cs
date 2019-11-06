using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_PM.Models;

namespace ProyectoFinal_PM.Controllers
{
    public class ProductosController : Controller
    {
        private VidaSaludableContext _context;

        public ProductosController(VidaSaludableContext c) 
        {
            _context = c;
        }

        public IActionResult Index()
        {
            var lista = _context.Productos.ToList();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Registro(Producto p)
        {
            if(ModelState.IsValid)
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }     
    }
}
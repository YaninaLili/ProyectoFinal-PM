using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_PM.Models;

namespace ProyectoFinal_PM.Controllers
{
    public class ServiciosController : Controller
    {
        private VidaSaludableContext _context;

        public ServiciosController(VidaSaludableContext c)
        {
            _context = c;
        }

        public IActionResult Index()
        {
            var lista = _context.Servicios.ToList();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Registro(Servicio s)
        {
            if (ModelState.IsValid)
            {
                _context.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }
}
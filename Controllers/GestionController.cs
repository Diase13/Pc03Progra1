using System.Linq;
using Pc03Progra1.Data;
using Pc03Progra1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pc03Progra1.Controllers
{
    public class GestionController : Controller
    {
        private readonly ProductoContext _context;
        public GestionController(ProductoContext c)
        {
            _context = c;
        }

        public IActionResult Lista()
        {   
            var lista = _context.Productos.ToList();

            return View(lista);
            
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto p)
        {  
            if (ModelState.IsValid)
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(p);
        }
    }
}
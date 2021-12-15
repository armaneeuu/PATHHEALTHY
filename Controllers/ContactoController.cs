using Microsoft.AspNetCore.Mvc;
using PATHHEALTHY.Models;
using PATHHEALTHY.Data;

namespace PATHHEALTHY.Controllers
{
    public class ContactoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "Su comentario se registro correctamente";
            return View("Index");
        }
    }
}
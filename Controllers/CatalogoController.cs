using Microsoft.AspNetCore.Mvc;
using PATHHEALTHY.Models;
using PATHHEALTHY.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace PATHHEALTHY.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CatalogoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProductos select o;
            productos = productos.Where(s =>s.Estado.Equals("A"));
            return View(await productos.ToListAsync());
        }
    }
}
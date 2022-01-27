using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using suaBaladaAqui.Models;

namespace suaBaladaAqui.Controllers
{
    public class SuaBaladaAquiController : Controller
    {
        private readonly suaBaladaAquiContext _context;

        public SuaBaladaAquiController(suaBaladaAquiContext context){
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            //Usuario user = new Usuario();
            var user = await _context.Eventos.ToListAsync();
            return View(user);
        }
    }
}
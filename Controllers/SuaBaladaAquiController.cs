using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using suaBaladaAqui.Models;
using suaBaladaAqui.ViewsModels;

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
            var query = (from evento in _context.Eventos
                        where evento.DataEvento >= DateTime.Today
                        //(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1)
                        orderby evento.DataEvento
                        select new boxBaladaViewsModels(evento.Evento1, evento.DataEvento.ToString("dd/MM"), evento.Cidade, 
                        evento.LocalName, evento.Imagem ));

            return View(await query.AsNoTracking().ToListAsync());
        }
    }
}
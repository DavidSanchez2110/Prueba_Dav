using Microsoft.AspNetCore.Mvc;
using Prueba_Dav.Models;
using Prueba_Dav.Models.ViewModels;
using System.Diagnostics;

namespace Prueba_Dav.Controllers
{
    public class HomeController : Controller
    {
        private readonly PruebaDavContext _dbcontext;

        public HomeController(PruebaDavContext context)
        {
            _dbcontext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] UsuarioCL oUsuarioCL)
        {
            Cliente oCliente = oUsuarioCL.oCliente;

            

            

            _dbcontext.Clientes.Add(oCliente);
            _dbcontext.SaveChanges();

            return Json(new { respuesta=true});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
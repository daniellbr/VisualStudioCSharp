using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Modelo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

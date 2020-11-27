using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var filme = new Filme()
            //{
            //    Titulo = "Oi",
            //    DataLancamento = DateTime.Now,
            //    Genero = null,
            //    Avaliacao = 10,
            //    Valor = 20000
            //};

            //return RedirectToAction("About", filme);
            return View();
        }

        public IActionResult About(Filme filme)
        {

            if (ModelState.IsValid)
            {

            }

            foreach (var erros in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(erros.ErrorMessage);
            }


            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

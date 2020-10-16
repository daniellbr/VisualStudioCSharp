using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.Modelos;
using Alura.ListaLeitura.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Alura.WebAPI.WebApp.Api
{
    public class ChuchuzinhoController : Controller
    {
        private readonly IRepository<Livro> _repo;

        public ChuchuzinhoController(IRepository<Livro> repository)
        {
            _repo = repository;
        }

        public IActionResult RetornaConsulta(int id)
        {
            var model = _repo.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            return Json(model.ToModel());
        }
    }

}

using DevIO.UI.Modelo.Data;
using DevIO.UI.Modelo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Modelo.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext meuDbContext)
        {
            _contexto = meuDbContext;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno {
                Nome = "jose",
                Email = "teste@teste.com.br",
                Anivesario = DateTime.Now
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno1 = _contexto.Alunos.Find(aluno.Id);
            var aluno2 = _contexto.Alunos.FirstOrDefault(buscaAluno => buscaAluno.Email == "teste");
            var aluno3 = _contexto.Alunos.Where(buscaAluno => buscaAluno.Nome == "jose");

            aluno.Nome = "Pedrinho";
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno2);
            _contexto.SaveChanges();


            return View("_Layout");
        }
    }
}

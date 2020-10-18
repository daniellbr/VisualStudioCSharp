using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.Modelos;
using Alura.ListaLeitura.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Lista = Alura.ListaLeitura.Modelos.ListaLeitura;

namespace Alura.WebAPI.WebApp.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListasLeituraController : ControllerBase
    {
        private readonly IRepository<Livro> _repo;

        public ListasLeituraController(IRepository<Livro> repository)
        {
            _repo = repository;
        }            

        private Lista CriaLista(TipoListaLeitura tipo)
        {
            return new Lista
            {
                Tipo = tipo.ParaString(),
                Livros = _repo.All           // Pega todos os registros da tabela
                .Where(l => l.Lista == tipo) // Onde l.Lista == tipo parametro entrada
                .Select(l => l.ToApi())      // O método ToApi faz o mapper
                .ToList()                    // Converte para Lista
            };
        }

       [HttpGet]
       public IActionResult TodasListas()
       {
            Lista paraLer = CriaLista(TipoListaLeitura.ParaLer); //Retorna a lista de Livros para Ler
            Lista lendo = CriaLista(TipoListaLeitura.Lendo);     //Retorna a lista de Livros Lendo
            Lista lidos = CriaLista(TipoListaLeitura.Lidos);     //Retorna a lista de Livros Lidos

            var colecaoListas = new List<Lista> { paraLer, lendo, lidos };

            return Ok(colecaoListas);
       }

        [HttpGet("{tipo}")]
        public IActionResult RecuperarListas(TipoListaLeitura tipo)
        {
            var recuperaLista = CriaLista(tipo);            

            return Ok(recuperaLista);
        }

    }
}

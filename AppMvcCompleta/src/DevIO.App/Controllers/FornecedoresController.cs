using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Controllers
{
    public class FornecedoresController : BaseController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository,
                                      IEnderecoRepository enderecoRepository,
                                      IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

        [Route("lista-de-fornecedores")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos()));
        }

        [Route("dados-do-fornecedor/{id:guid}")]
        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedorEndereco(id);

            if (fornecedorViewModel == null) return NotFound();

            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Create
        [Route("novo-fornecedor")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create      
        [Route("novo-fornecedor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FornecedorViewModel fornecedorViewModel)
        {
            if (!ModelState.IsValid) return View(fornecedorViewModel);

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorRepository.Adicionar(fornecedor);

            return RedirectToAction(nameof(Index));

        }

        // GET: Seleciona para Editar Fornecedores
        [Route("editar-fornecedor/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedorProdutoEndereco(id);

            if (fornecedorViewModel == null) return NotFound();

            return View(fornecedorViewModel);
        }

        // POST: Fornecedores/Edit/5
        [Route("editar-fornecedor/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, FornecedorViewModel fornecedorViewModel)
        {
            if (id != fornecedorViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(fornecedorViewModel);

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorRepository.Atualizar(fornecedor);

            return RedirectToAction(nameof(Index));
            
        }

        // GET: Seleciona para Excluir Fornecedores
        [Route("excluir-fornecedor/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedorEndereco(id);
                
            if (fornecedorViewModel == null) return NotFound();            

            return View(fornecedorViewModel);
        }

        // POST: Fornecedores/Delete/5
        [Route("excluir-fornecedor/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedorEndereco(id);
            
            if (fornecedorViewModel == null) return NotFound();
            
            await _fornecedorRepository.Remover(id);
            
            return RedirectToAction(nameof(Index));
        }

        [Route("obter-endereco-fornecedor/{id:guid}")]
        private async Task<ActionResult> ObterEndereco(Guid id)
        {
            var enderecoFornecedor = await ObterFornecedorEndereco(id);

            if (enderecoFornecedor == null) return NotFound();

            return PartialView("_DetalhesEndereco", enderecoFornecedor);
        }
                
        public async Task<IActionResult> AtualizarEnderecoModal(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if (fornecedor == null) return NotFound();

            return PartialView("_AtualizarEndereco", new FornecedorViewModel { Endereco = fornecedor.Endereco });
        }

        [Route("atualizar-endereco-fornecedor/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtualizarEndereco(FornecedorViewModel fornecedorViewModel)
        {
            ModelState.Remove("Nome");
            ModelState.Remove("Documento");

            if (!ModelState.IsValid) return PartialView("_AtualizarEndereco", fornecedorViewModel);


            await _enderecoRepository.Atualizar(_mapper.Map<Endereco>(fornecedorViewModel.Endereco));

            var url = Url.Action("ObterEndereco", "Fornecedores", new { id = fornecedorViewModel.Endereco.FornecedorId });

            return Json(new { sucess = true, url });
        }


        private async Task<FornecedorViewModel> ObterFornecedorEndereco(Guid id)
        {
            return (_mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorEndereco(id)));
        }        

        private async Task<FornecedorViewModel> ObterFornecedorProdutoEndereco(Guid id)
        {
            return (_mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorProdutosEndereco(id)));
        }
    }
}

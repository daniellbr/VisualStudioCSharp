using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DevIO.App.Controllers
{
    public class ProdutosController : BaseController
    {
        private readonly IProdutoRepository _produtosRepository;
        private readonly IProdutoService _produtosService;
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository,
                                  IProdutoService produtoService,  
                                  IFornecedorRepository fornecedorRepository,
                                  IMapper mapper,
                                  INotificador notificador) : base (notificador)
        {
            _produtosRepository = produtoRepository;
            _produtosService = produtoService;
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        // GET: Produtos
        [Route("lista-de-produtos")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>
                       (await _produtosRepository.ObterProdutosFornecedores()));
        }

        // GET: Produtos/Details/5
        [Route("dados-do-produto/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        // GET: Produtos/Create
        [Route("novo-produto")]
        public async Task<IActionResult> Create()
        {
            var popularProdutoVieModel = await PopularFornecedores(new ProdutoViewModel());

            return View(popularProdutoVieModel);
        }

        // POST: Produtos/Create                
        [Route("novo-produto")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            produtoViewModel = await PopularFornecedores(produtoViewModel);

            if (!ModelState.IsValid) return View(produtoViewModel);

            produtoViewModel.Imagem =
                    await ImagemPrefixo(produtoViewModel) +
                    produtoViewModel.ImagemUpload.FileName;

            await _produtosService.Adicionar(_mapper.Map<Produto>(produtoViewModel));

            if (!OperacaoValida()) return View(produtoViewModel);

            return RedirectToAction("Index"); ;
        }


        // GET: Produtos/Edit/5
        [Route("editar-produto/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var produtoViewModel = await ObterProdutoFornecedor(id);

            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        // POST: Produtos/Edit/5
        [Route("editar-produto/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id) return NotFound();

            var produtoAtualizando = await ObterProduto(id);
            produtoViewModel.Fornecedor = produtoAtualizando.Fornecedor;
            produtoViewModel.Imagem = produtoAtualizando.Imagem;

            if (!ModelState.IsValid) return View(produtoViewModel);

            if (produtoViewModel.ImagemUpload != null)
            {
                produtoAtualizando.Imagem =
                    await ImagemPrefixo(produtoViewModel) +
                    produtoViewModel.ImagemUpload.FileName;
            }

            produtoAtualizando.Nome = produtoViewModel.Nome;
            produtoAtualizando.Descricao = produtoViewModel.Descricao;
            produtoAtualizando.Valor = produtoViewModel.Valor;
            produtoAtualizando.Ativo = produtoViewModel.Ativo;

            var produto = _mapper.Map<Produto>(produtoAtualizando);

            await _produtosService.Atualizar(produto);

            if (!OperacaoValida()) return View(produtoViewModel);

            return RedirectToAction("Index");
        }

        // GET: Produtos/Delete/5
        [Route("excluir-produto/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var produto = await ObterProdutoFornecedor(id);

            if (produto == null) return NotFound();

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [Route("excluir-produto/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produto = await ObterProdutoFornecedor(id);

            if (produto == null) return NotFound();

            await _produtosService.Remover(id);

            if (!OperacaoValida()) return View(produto);

            TempData["Sucesso"] = ("Registro deletado com sucesso");

            return RedirectToAction("Index");
        }

        private async Task<ProdutoViewModel> ObterProduto(Guid id)
        {
            var produto = (_mapper.Map<ProdutoViewModel>(await _produtosRepository.ObterProdutoFornecedor(id)));            

            return produto;
        }

        private async Task<ProdutoViewModel> ObterProdutoFornecedor(Guid id)
        {
            var produto = (_mapper.Map<ProdutoViewModel>(await _produtosRepository.ObterProdutoFornecedor(id)));
            produto.Fornecedores = (_mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos()));

            return produto;
        }

        private async Task<ProdutoViewModel> PopularFornecedores(ProdutoViewModel produto)
        {
            produto.Fornecedores = (_mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos()));

            return produto;
        }

        private async Task<bool> UploadImagem(IFormFile imagemUpload, string imgPrefixo)
        {
            if (imagemUpload.Length <= 0) return false;

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagens", imgPrefixo + imagemUpload.FileName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
                return false;
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imagemUpload.CopyToAsync(stream);
            }
            return true;
        }

        private async Task<string> ImagemPrefixo(ProdutoViewModel produtoViewModel)
        {
            var imgPrefixo = Guid.NewGuid() + "_";

            await UploadImagem(produtoViewModel.ImagemUpload, imgPrefixo);

            return imgPrefixo;
        }
    }
}

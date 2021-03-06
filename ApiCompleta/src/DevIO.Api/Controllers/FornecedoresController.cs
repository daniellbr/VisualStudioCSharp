﻿using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Api.Controllers
{
    [Route("api/[controller]")]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _fornecedoRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper; //Criando uma variavel do tipo IMapper

        public FornecedoresController(IFornecedorRepository fornecedorRepository, 
                                      IFornecedorService fornecedorService,
                                      IMapper mapper)
        { 
            _fornecedoRepository = fornecedorRepository; //Injetando no construtor a interface de Fornecedor Repository
            _fornecedorService = fornecedorService; //Injetando no construror a interface de FornecedorService
            _mapper = mapper; //Injetando no construtor a interface do AutoMapper
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            //var fornecedor = await  _fornecedoRepository.ObterTodos();// Da maneira como está a variavel fornecedor recebe uma entidade de Fornecedor e não a FornecedorViewModel. Essa pratica não é recomentada então temos que fazer o Mapper da Entidade para ViewModel
            var fornecedor = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedoRepository.ObterTodos());

            return Ok(fornecedor);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<FornecedorViewModel>> ObterPorId(Guid id)
        {
            var forncedor = await ObterForncedorProdutosEndereco(id);

            if (forncedor == null) return NotFound();
            

            return Ok(forncedor);
        }

        public async Task<FornecedorViewModel> ObterForncedorProdutosEndereco(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _fornecedoRepository.ObterFornecedorProdutosEndereco(id));
        }

        [HttpPost]
        public async Task<ActionResult<FornecedorViewModel>> Adicionar(FornecedorViewModel fornecedorViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);

            var result = await _fornecedorService.Adicionar(fornecedor);

            if (!result) return BadRequest();

            return Ok();
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<FornecedorViewModel>> Atualizar(Guid id, FornecedorViewModel fornecedorViewModel)
        {
            if (id != fornecedorViewModel.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);

            var result = await _fornecedorService.Atualizar(fornecedor);

            if (!result) return BadRequest();

            return Ok(fornecedor);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<FornecedorViewModel>> Excluir(Guid id)
        {
            var fornecedor = ObterFornecedorEndereco(id);

            if (fornecedor == null) return NotFound();

            var result = await _fornecedorService.Remover(id);

            if (!result) return BadRequest();

            return Ok(fornecedor);

        }

        public async Task<FornecedorViewModel> ObterFornecedorEndereco(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _fornecedoRepository.ObterFornecedorEndereco(id));
        }

    }
}

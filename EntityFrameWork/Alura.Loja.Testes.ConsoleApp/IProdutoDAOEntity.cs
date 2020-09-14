﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class IProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext contexto;

        public IProdutoDAOEntity()
        {
            this.contexto = new LojaContext();
        }
        public void Adicionar(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            contexto.Produtos.Update(produto);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return contexto.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }
    }
}

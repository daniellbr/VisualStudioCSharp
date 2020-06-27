using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Intercafes;
using System.Collections.Generic;

namespace ControleEstoque.Data
{
    public interface IProdutoRepository: IRepositoryBase<Produto>
    {
        IEnumerable<Produto> ObterProdutosPromocao();
    }
}

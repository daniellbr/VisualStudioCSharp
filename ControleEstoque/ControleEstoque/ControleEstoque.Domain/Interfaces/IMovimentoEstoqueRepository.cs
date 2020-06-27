using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Intercafes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Data
{
    public interface IMovimentoEstoqueRepository : IRepositoryBase<MovimentoEstoque>
    {
        IEnumerable<MovimentoEstoque> ObterMovimentoEntrada();

        IEnumerable<MovimentoEstoque> ObterMovimentoSaida();
    }
}

using ControleEstoque.Domain.Enuns;
using System;

namespace ControleEstoque.Domain.Entities
{
    public class MovimentoEstoque :Entity
    {
        public int Quantidade { get; private set; }
        public DateTime DataMovimento { get; private set; }
        public int PropodutoId { get; set; }
        public Produto Produto { get; private set; }
        public EMovimentoTipo TipoMovimento { get; private set; }
    }
}

using ControleEstoque.Domain.Enuns;
using System;

namespace ControleEstoque.Domain.Entities
{
    public class MovimentoEstoque :Entity
    {
        public MovimentoEstoque(int quantidade, DateTime dataMovimento, EMovimentoTipo tipoMovimento)
        {
            Quantidade = quantidade;
            DataMovimento = dataMovimento;
            TipoMovimento = tipoMovimento;
        }

        public int Quantidade { get; private set; }
        public DateTime DataMovimento { get; private set; }
        public EMovimentoTipo TipoMovimento { get; private set; }
        
        //Propriedade de navegação
        public int ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
    }
}

using ControleEstoque.Domain.Enuns;

namespace ControleEstoque.Domain.Entities
{
    public class Produto :Entity
    {
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int MyProperty { get; private set; }
        public EMovimentoTipo TipoMovimento{ get; private set; }


    }
}

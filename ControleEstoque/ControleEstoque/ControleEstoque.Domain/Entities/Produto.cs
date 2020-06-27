using System.Collections.Generic;


namespace ControleEstoque.Domain.Entities
{
    public class Produto :Entity
    {
        public Produto(string descricao, decimal valor, )
        {
            Descricao = descricao;
            Valor = valor;
        }
        public string Descricao { get; private set; }
        
        //Propriedade de navegação
        public decimal Valor { get; private set; }
        public IEnumerable<MovimentoEstoque> MovimentoEstoque { get; private set; }
        

    }
}

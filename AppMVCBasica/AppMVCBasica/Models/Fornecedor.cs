using System.Collections.Generic;

namespace AppMVCBasica.Models
{
    public partial class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations 1 => N  */

        public IEnumerable<Produto> Produtos { get; set; }
    }
}

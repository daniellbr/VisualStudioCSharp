namespace ByteBank
{
   public class Cliente
    {
        //Esta forma sem a criação do campo propriamente dito é feito quando não há nenhuma atribuição ou logica no mesmo
        //Quando necessitar fazer alguma logica é só criar o campo exemplo _cpf e expandir o get e set 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente; //Neste caso está havendo uma excessão porém está ocorrendo um excessão do tipo null
                                                   //Pois os argumentos Cliente e ContaCorrente não batem fazendo com que o objeto 
                                                   //outroCliente retorne NULL
            if (outroCliente == null)
            {
                return false;
            }

            return Nome == outroCliente.Nome && CPF == outroCliente.CPF && Profissao == outroCliente.Profissao;
         
            //Cliente outroCliente = (Cliente)obj; // Esse é um tipo de Cast
            // Fazendo desta maneira com Cast, vai ocorrer um exceção pois não será possivel converter um objeto do tipo 
            // ContaCorrente em um objeto do tipo Cliente.
            //return Nome == outroCliente.Nome && CPF == outroCliente.CPF && Profissao == outroCliente.Profissao;

        }

    }
}

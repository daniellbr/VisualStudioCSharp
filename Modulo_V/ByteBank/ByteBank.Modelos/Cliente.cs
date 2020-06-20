namespace ByteBank
{
   public class Cliente
    {
        //Esta forma sem a criação do campo propriamente dito é feito quando não há nenhuma atribuição ou logica no mesmo
        //Quando necessitar fazer alguma logica é só criar o campo exemplo _cpf e expandir o get e set 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
                
    }
}

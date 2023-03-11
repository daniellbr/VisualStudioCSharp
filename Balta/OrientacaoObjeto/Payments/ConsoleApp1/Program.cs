using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new PagamentoCartao(DateTime.Now);
            pagamento.Pagar("1255");
        }
    }

    
    /*
       Nesta aplicação foi abordado sobrescrita, 
       sobrecarga e metodo construtores
    */
    public class Pagamento
    {  
        public DateTime DataPagamento{get;set;}

        //public Pagamento() {} //Contrutor parameterless construtor sem parametro
        public Pagamento(DateTime vecimento)
        {
           Console.WriteLine("Iniciando o pagamento"); 
           DataPagamento = DateTime.Now;
        }

        public virtual void Pagar(string numero)
        {
           Console.WriteLine("Pagar");
        }
       
    }

    public class PagamentoCartao : Pagamento
    {     
        public PagamentoCartao(DateTime vencimento) : base(vencimento) {}
        public override void Pagar(string numero)
        {
            base.Pagar(numero);
            Console.WriteLine("Pagar Cartão");
        }
    }
}

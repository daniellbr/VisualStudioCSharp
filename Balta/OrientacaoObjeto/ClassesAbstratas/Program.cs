using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pagamento = new PagamentoCartao();
            pagamento.Pagar(5);

            var pagamentoCheque = new PagamentoCheque();
            pagamentoCheque.Pagar(12);
        }
    }

    public interface IPagamento
    {
        public DateTime DataPagamento { get; set; }

        void Pagar(double valor);
    }

    //Classe abstrata não pode ser instanciada somente pode ser herdada
    public abstract class Pagamento : IPagamento
    {
        public DateTime DataPagamento { get; set; }

        public virtual void Pagar(double valor)
        {
            DataPagamento = DateTime.Now;
            Console.WriteLine($"Iniciando o pagamento com o valor de {valor}");
        }
    }

    public class PagamentoCartao : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
            Console.WriteLine("Pagamento com Cartão");
        }
    }
    public class PagamentoCheque : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
            Console.WriteLine("Pagamento com Cheque");
        }
    }
}

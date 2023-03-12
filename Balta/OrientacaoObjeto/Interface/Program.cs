using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public interface IPagamento
        {
            DateTime HoraPagamento { get; set; }

            void Pagar(double valorPagamento);
        }

        public class Pagamento : IPagamento
        {
            public DateTime HoraPagamento { get; set; }

            public void Pagar(double valor)
            {

            }
        }
    }
}

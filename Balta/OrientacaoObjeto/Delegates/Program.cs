using System;

namespace Delegates
{
    class Program
    {
        public static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago valor de {valor}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pagar = new Pagamento.Pagar(RealizarPagamento);

            pagar(25);
        }
    }

    public class Pagamento
    {
        public delegate void Pagar(double valor);

    }
}

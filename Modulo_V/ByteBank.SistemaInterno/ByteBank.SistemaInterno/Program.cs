using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(4343, 656577);
            Console.WriteLine(contaCorrente.Saldo);
            Console.ReadLine();

         
        }
    }
}

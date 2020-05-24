using ByteBank_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank06
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine(conta.ObterSalto());

            conta.DefinirSaldo(1);

            Console.WriteLine(conta.ObterSalto());


            Console.ReadLine();
        }
    }
}

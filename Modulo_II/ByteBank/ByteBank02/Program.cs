using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.saldo += 200;

            Console.WriteLine(contaCorrente.saldo);

            Console.ReadLine();
                
        }
    }
}

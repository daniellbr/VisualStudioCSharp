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
            Cliente cliente = new Cliente();

            Console.WriteLine(conta.Saldo);

            cliente.Nome = "daniel";
            cliente.CPF = "1234556677";
            cliente.Profissao = "tester";

            conta.Titular = cliente;


            conta.Saldo = 1;

            Console.WriteLine(conta.Saldo);


            Console.ReadLine();
        }
    }
}

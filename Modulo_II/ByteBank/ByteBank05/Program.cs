using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela";
            conta.titular.cpf = "223.332.332-32";
            conta.titular.profissao = "Desenvolvedora de software";

            Cliente gabriela = new Cliente();

            gabriela = conta.titular;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();

        }
    }
}

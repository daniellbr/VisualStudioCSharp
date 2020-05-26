using ByteBank_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank07
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(133,1234568);
            Cliente cliente1 = new Cliente();

            cliente1.Nome = "João";
            cliente1.CPF = "123.454.789-20";
            cliente1.Profissao = "Desenvolvedor";
            conta.Titular = cliente1;

            //conta.Titular.Nome = "João";
            //conta.Titular.CPF = "123.454.789-20";
            //conta.Titular.Profissao = "Desenvolvedor";
            //cliente1 = conta.Titular;
            
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.NumeroConta);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaGabriela = new ContaCorrente(133, 1234569);
            Cliente cliente2 = new Cliente();

            cliente2.Nome = "Gabriela";
            cliente2.CPF = "343.554.865-27";
            cliente2.Profissao = "Auxiliar";
            contaGabriela.Titular = cliente2;

            Console.WriteLine(contaGabriela.Titular.Nome);
            Console.WriteLine(contaGabriela.Agencia);
            Console.WriteLine(contaGabriela.NumeroConta);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);





            Console.ReadLine();
            
        }
    }
}

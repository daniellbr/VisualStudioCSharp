using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrenteDaGabriela = new ContaCorrente();

            contaCorrenteDaGabriela.titular = "Gabriela";
            contaCorrenteDaGabriela.agencia = 863;
            contaCorrenteDaGabriela.numeroConta = 863452;
            contaCorrenteDaGabriela.saldo = 100.00;

            Console.WriteLine(contaCorrenteDaGabriela.titular);
            Console.WriteLine("Agencia " + contaCorrenteDaGabriela.agencia);
            Console.WriteLine("NumeroConta " + contaCorrenteDaGabriela.numeroConta);
            Console.WriteLine("Saldo " + contaCorrenteDaGabriela.saldo);
                        
            ContaCorrente contaCorrenteDaJoao = new ContaCorrente();

            Console.WriteLine(contaCorrenteDaJoao.titular);
            Console.WriteLine("Agencia " + contaCorrenteDaJoao.agencia);
            Console.WriteLine("NumeroConta " + contaCorrenteDaJoao.numeroConta);
            Console.WriteLine("Saldo " + contaCorrenteDaJoao.saldo);

            Console.WriteLine("Igualdade de referencia = " + (contaCorrenteDaGabriela == contaCorrenteDaJoao));

            int i = 10;
            int x = 10;

            Console.WriteLine("Igualdade de tipo de valor = " + (i == x));

            Console.ReadLine();
        }
    }
}

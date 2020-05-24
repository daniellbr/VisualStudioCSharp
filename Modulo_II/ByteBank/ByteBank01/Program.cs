using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
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

            contaCorrenteDaGabriela.saldo += 200.00;


            Console.WriteLine(contaCorrenteDaGabriela.titular);
            Console.WriteLine("Agencia " + contaCorrenteDaGabriela.agencia);
            Console.WriteLine("NumeroConta " + contaCorrenteDaGabriela.numeroConta);
            Console.WriteLine("Saldo " + contaCorrenteDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}

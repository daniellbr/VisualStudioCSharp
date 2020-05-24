using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrenteBruno = new ContaCorrente();

            contaCorrenteBruno.titular = "Bruno";

            Console.WriteLine(contaCorrenteBruno.saldo);

            bool retornoConta = contaCorrenteBruno.Sacar(50);

            Console.WriteLine(contaCorrenteBruno.saldo);
                        
            string mensagemSaldo = contaCorrenteBruno.Depositar(300);
                        
            Console.WriteLine(mensagemSaldo);



            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
                        

            Console.WriteLine("Conta corrente Bruno   : " + contaCorrenteBruno.saldo);

            Console.WriteLine("Conta corrente Gabriela: " + contaGabriela.saldo);


            bool resultadoTransferencia = contaCorrenteBruno.Transferir(50, contaGabriela);


            Console.WriteLine("Conta corrente Bruno   : " + contaCorrenteBruno.saldo);

            Console.WriteLine("Conta corrente Gabriela: " + contaGabriela.saldo);

            Console.WriteLine("O resultado da transferencia foi :" + resultadoTransferencia);

            // ----

            Console.WriteLine("Conta corrente Bruno   : " + contaCorrenteBruno.saldo);

            Console.WriteLine("Conta corrente Gabriela: " + contaGabriela.saldo);

            resultadoTransferencia = contaGabriela.Transferir(149.99, contaCorrenteBruno);

            Console.WriteLine("Conta corrente Bruno   : " + contaCorrenteBruno.saldo);

            Console.WriteLine("Conta corrente Gabriela: " + contaGabriela.saldo);

            Console.WriteLine("O resultado da transferencia foi :" + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}

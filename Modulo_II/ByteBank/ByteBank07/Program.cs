using ByteBank_07;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank07
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.ReadLine();
        }


        public static void CarregarContas()
        {
            using (LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo("arquivo.txt"))
            {
                leitorDeArquivo.LendoProximaLinha();
            }
                



            //LeitorDeArquivo leitorDeArquivo = null;
            //try
            //{
            //    leitorDeArquivo = new LeitorDeArquivo("contas.txt");
            //    leitorDeArquivo.LendoProximaLinha();
            //    leitorDeArquivo.LendoProximaLinha();
            //    leitorDeArquivo.LendoProximaLinha();
            //    leitorDeArquivo.LendoProximaLinha();

            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Erro de IOException capturada e tradada!");
            //}
            //finally
            //{
            //    if (leitorDeArquivo != null)
            //    {
            //        leitorDeArquivo.Fechar();
            //    }
            //}

        }

        public static void TestarInnerException()
        {
            try
            {
                criarContaEClientesTeste();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Agora o StackTrace do InnerException");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);


            }
        }


        public static void criarContaEClientesTeste()
        {
            ContaCorrente conta = new ContaCorrente(55, 4520);
            ContaCorrente conta1 = new ContaCorrente(45, 545454);

            // conta.Transferir(150, conta1);
            // conta.Depositar(100);
            conta.Sacar(2300);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);

            ////conta.Titular.Nome = "João";
            ////conta.Titular.CPF = "123.454.789-20";
            ////conta.Titular.Profissao = "Desenvolvedor";
            ////cliente1 = conta.Titular;

            //Console.WriteLine(conta.Titular.Nome);
            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.NumeroConta);
            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //ContaCorrente contaGabriela = new ContaCorrente(133, 1234569);
            //Cliente cliente2 = new Cliente();

            //cliente2.Nome = "Gabriela";
            //cliente2.CPF = "343.554.865-27";
            //cliente2.Profissao = "Auxiliar";
            //contaGabriela.Titular = cliente2;

            //Console.WriteLine(contaGabriela.Titular.Nome);
            //Console.WriteLine(contaGabriela.Agencia);
            //Console.WriteLine(contaGabriela.NumeroConta);
            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }

    }
}

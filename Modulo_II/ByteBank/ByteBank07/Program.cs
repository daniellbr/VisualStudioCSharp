using ByteBank_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank07
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                criarContaEClientesTeste();               
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.ValorSaque);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
                Console.WriteLine(ex.StackTrace);
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(e);
            }



            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro!" + e);                
            }
            Console.ReadLine();
        }

        public static void criarContaEClientesTeste()
        {
            ContaCorrente conta = new ContaCorrente(55,4520);
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "João";
            cliente1.CPF = "123.454.789-20";
            cliente1.Profissao = "Desenvolvedor";            
            conta.Titular = cliente1;

            ContaCorrente conta1 = new ContaCorrente(45, 545454);

            conta.Transferir(150, conta1);
           // conta.Depositar(100);
           // conta.Sacar(-300);
            
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

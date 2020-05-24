using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - calcula poupança");

            double valorInvestido = 1000;

            int contadorMeses = 1;

            while (contadorMeses <= 192)
            {
                valorInvestido += (valorInvestido * 0.0036); //0,36% = 0,0036

                if (contadorMeses == 1)                
                    Console.WriteLine("Após " + contadorMeses + " mês o valor investido na poupança é : R$" + valorInvestido);
                else
                {
                    Console.WriteLine("Após " + contadorMeses + " meses o valor investido na poupança é : R$" + valorInvestido);
                }
                //formas de incrementar
                //contadorMeses = contadorMeses + 1;
                //contadorMeses += 1;
                
                contadorMeses++;

                
            }


            //Esse código poderia funcioanar porem ele ficaria muito extenso, utilizando o while podemos simplificar esse calculo
            //valorInvestido = valorInvestido + (valorInvestido * 0.0036); //0,36% = 0,0036

            //Console.WriteLine("Após 1 mês o valor investido na poupança é : " + valorInvestido);

            //valorInvestido = valorInvestido + (valorInvestido * 0.0036); //0,36% = 0,0036

            //Console.WriteLine("Após 2 meses o valor investido na poupança é : " + valorInvestido);


            Console.ReadLine();
        }
    }
}

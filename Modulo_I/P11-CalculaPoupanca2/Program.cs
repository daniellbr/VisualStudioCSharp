using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 11 - Calcula Popupança 2");

            double valorInvestido = 1000;
            double rentabilidade = 1.0036;

            for(int contadorMes = 1; contadorMes <= 192; contadorMes++)
            {
                //essa é uma forma para o calculo mas da para simplificala
                //valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                //valorInvestido += (valorInvestido * 0.0036);

                valorInvestido *= rentabilidade;

                if (valorInvestido == 1)
                
                    Console.WriteLine("Após " + contadorMes + " mês, o valor investido na poupança é : R$" + valorInvestido);
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses, o valor investido na poupança é : R$" + valorInvestido);
                }               
            }

            Console.ReadLine();
        }
    }
}

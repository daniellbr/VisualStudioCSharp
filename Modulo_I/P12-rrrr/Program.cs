using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Calculando Investimentos de longo prazo");

            double fatorRendimento = 1.0036;
            double valorInvestimento = 1000;

            for (int contadorAno = 0; contadorAno < 5; contadorAno++)
            {

                for (int contadorMes = 0; contadorMes < 12; contadorMes++)
                {
                    valorInvestimento *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do periodo o valor investido será : R$" + valorInvestimento);

            Console.ReadLine();
        }
    }
}

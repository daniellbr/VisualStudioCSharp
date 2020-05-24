using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int maiorIdade = 0;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("A idade de joão é maior de 18 pode entrar " + idadeJoao);
            } else
            { if (maiorIdade >= 1)
                {
                    Console.WriteLine("João é menor de idade mas está acompanhado pode entrar");
                } else
                {
                    Console.WriteLine("João não possui mais de 18 anos " + idadeJoao);
                }                
            }

            Console.ReadLine();
        }
    }
}

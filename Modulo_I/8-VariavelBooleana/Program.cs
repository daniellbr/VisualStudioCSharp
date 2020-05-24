using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_VariavelBooleana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7.2 - Condicionais");

            int idadeJoao = 16;
            int maiorIdade = 0;
            bool acompanhado = maiorIdade >= 1;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("A idade de joão é maior de 18 pode entrar " + idadeJoao);
            }
            else
            {               
                Console.WriteLine("João não possui mais de 18 anos " + idadeJoao);                
            }

            Console.ReadLine();
        }
    }
}

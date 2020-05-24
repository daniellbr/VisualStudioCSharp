using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 Atribuicoes de variavies");

            int idade = 32;

            int idadePedro = idade;

            Console.WriteLine("Idade é igual " + idade);
            Console.WriteLine("Idade é igual Pedro " + idadePedro);

            idade = 33;

            //O valor atribuido não segue o valor da variavel toda vez que ela sofre alteração
            Console.WriteLine("Idade é igual " + idade);

            Console.ReadLine();
        }
    }
}

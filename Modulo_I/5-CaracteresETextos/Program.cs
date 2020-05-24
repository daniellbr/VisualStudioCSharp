using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //character

            char primeiraLetra = 'a';

            Console.WriteLine("Essa é a primeira letra " + primeiraLetra);


            //Esses valores de números é a conversão para a tabela ASC
            primeiraLetra = (char)65;

            Console.WriteLine("Essa é a primeira letra em formato numerico " + primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);

            Console.WriteLine("O valor da primeira letra com a soma é " + primeiraLetra);

            string titulo = "Texto do joazinho";

            Console.WriteLine("Esse é o titulo da string " + titulo);

            string concatena = "Sera que funciona esse " +
                "esquema de teclar enter" +
                "parece que funciona";
            Console.WriteLine("Esse é o texto concatenado " + concatena);

            string concat = 
@"Estou textando
- vamos ver se vai
- não sei não
- parece que vai";

            Console.WriteLine("Esse texto é o concat gambi " + concat);
            //para montar uma string que fique toda na mesma posição deve-se tirar os espaços e utilizar o @ no inicio da string e tirar as demais aspas


            Console.ReadLine();
        }
    }
}

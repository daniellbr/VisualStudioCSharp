using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 For Encadeado");

            // *
            // ** 
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {                
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)                    
                        break;                    
                }
                Console.WriteLine();
            }

            //Forma mais limpa para o mesmo código
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)                
                    Console.Write("*");
                
                Console.WriteLine();
            }

            //For para imprimir os números de 1 a 5 crescente 
            // 1
            // 12
            // 123
            // 1234
            // 12345

            for (int contadorLinha = 0; contadorLinha < 5; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 5; contadorColuna++)
                {
                    Console.Write(contadorColuna + 1);
                    if (contadorColuna >= contadorLinha)
                        break;

                }
                Console.WriteLine();
            }


            //Laço de repetição para imprimir a tabuada

            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            //Laço de repetição para montar uma matriz
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                        break;
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //Imprimir multiplos de 3            
            for (int contador = 0; contador < 100; contador++)
            {
                if (contador % 3 == 0)
                    Console.WriteLine(contador);
            }

            //Imprimir multiplos de 3 - Formato mais simples
            for (int contador = 3; contador < 100; contador+=3)                           
                Console.WriteLine(contador);


            // Fatorial de 10 
            int fatorial = 1;         
            for (int contador = 1; contador < 11; contador++)
            {
                fatorial *= contador;

                Console.WriteLine("O fatorial de " + contador + "! = " + fatorial);
            }
                




            Console.ReadLine();
        }
    }
}

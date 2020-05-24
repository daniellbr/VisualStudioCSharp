using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario;

            salario = 1124.54;

            Console.WriteLine("Meu salario é " + salario);

            //Sempre que for necessário utilizar o valor decimal, deve-se colocar o campo no calculo com . e o valor decimal ou caso vc queira o resultado de um calculo preciso 
            //o divisor ou o dividido deve conter o .0

            salario = 12.6 / 3;

            Console.WriteLine("O valor é " + salario);

            salario = 12 / 3.3;

            Console.WriteLine("O valor é 2" + salario);

            Console.ReadLine();
        }
    }
}

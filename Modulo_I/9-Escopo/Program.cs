using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");

            int idadeJoao = 16;
            int maiorIdade = 0;
            bool acompanhado = maiorIdade >= 1;
            string mensagemAdicional;

            //Escopo é onde pode ser declarado uma variavel, caso vc declare a string msg adicional dentro de um if por exemplo, ela só poderá ser
            //utilizada dentro do if, por isso colocamos igual está no código acima para ela contemplar todo o contexto

            if (acompanhado == true)
            {
                mensagemAdicional = "João esta acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}

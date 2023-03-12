using System;

namespace ClassesSeladas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teste = new Teste();
            teste.Hora = DateTime.Now;

            Console.WriteLine($"Zinbabre {teste.Hora}");
        }

        public sealed class Teste
        {
            public DateTime Hora { get; set; }

            public Teste()
            {
                Console.WriteLine("Não é possivel executar nenhum códido dentrro da classe, é necessário o construtor ou um método");

                Console.WriteLine("Classes seladas ou sealed não permitem a utilização de herança");
            }
        }
    }
}

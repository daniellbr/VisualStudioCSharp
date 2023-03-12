using System;
using Pagamento;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teste = new Pagamentos();
            teste.MyPropertyA = 1;
            teste.MyPropertyB = 2;

            Console.WriteLine("Com o partial da para dividir o código para não ficar tao extenso");
            Console.WriteLine($"Tem estes valores de {teste.MyPropertyA} e também {teste.MyPropertyB}");
        }
    }
}

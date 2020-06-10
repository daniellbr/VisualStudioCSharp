using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();   
            }
            catch (System.Exception erro)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine(erro.Message);
                Console.ReadLine();
            }
            
        }

        public static void Metodo()
        {
            TestaDivisao(0);
        }
        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
        public static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}

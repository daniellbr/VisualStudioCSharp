using ByteBank.Modelos;
using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateEndPayment = new DateTime(2018, 4, 21);

            DateTime CurrentDate = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(32);

            string mensagem = "O valor é " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();

        }
    }
}

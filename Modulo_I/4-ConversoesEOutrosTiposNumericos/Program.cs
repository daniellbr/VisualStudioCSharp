using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            byte k;
            k = 127;
            Console.WriteLine("Olá eu sou um numero byte " + k);


            double q;
            q = 122.40;
            Console.WriteLine("Olá eu sou um numero double " + q);

            //O short é uma varivael que suporta até 16 bits
            short y;
            y = 32767;

            Console.WriteLine("Olá eu sou um numero short " + y);

            //O int é uma variavel que suporta até 32 bits
            int x;
            x = 2147483647;
            Console.WriteLine("Olá eu sou um numero int " + x);

            //O long é uma variavel que suporta até 64 bits
            long z;
            z = 9223372036854775807;
            Console.WriteLine("Olá eu sou um numero long " + z);

            //O float por não ser tão usual é necessário colocar o f ao final para indicar ao compilador
            float w;
            w = 55.5554125456f;
            Console.WriteLine("Olá eu sou um numero float " + w);

            Console.ReadLine();
        }
    }
}

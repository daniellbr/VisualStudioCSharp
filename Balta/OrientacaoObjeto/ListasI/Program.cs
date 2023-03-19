using System;
using System.Collections.Generic;

namespace ListasI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Em ordem de grandeza LIST comporta todas as listas possiveis é a mais completa

            //IEnumerable é a lista mais simples

            // Não é possivel criar uma lista IEnumerable pois como é uma interface e não 
            // é possivel instanciar uma lista, devemos
            //Implementar a interface IEnumerable. Uma maneira de corrigir isso é conforme 
            // Abaixo criamos to tipo IEnumerable porém de um tipo mais completo o LIST
            IEnumerable<Payment> payments = new List<Payment>();

            // var paymentsI = new ICollection<Payment>();
            var paymentsII = new List<Payment>();

        }
    }

    public class Payment
    {

    }
}

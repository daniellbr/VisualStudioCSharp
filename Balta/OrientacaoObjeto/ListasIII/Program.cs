using System;
using System.Collections.Generic;
using System.Linq;

namespace ListasII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var payments = new List<Payment>(1);
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));
            payments.Add(new Payment(6));
            payments.Add(new Payment(7));
            payments.Add(new Payment(8));
            payments.Add(new Payment(9));

            //é possivel converter para Enumerable
            payments.AsEnumerable();

            //é possivel converter para array
            payments.ToArray();

            //é possivel converter de ienumerable para list
            IEnumerable<Payment> pagto = new List<Payment>(1);
            pagto.ToList();
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}

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

            foreach (var payment in payments)
            {
                Console.WriteLine($"Pagamento {payment.Id}");
            }

            //Where sempre ira retornar uma lista mesmo que o retorno seja somente 1
            var paymentList = payments.Where(p => p.Id == 9);
            Console.WriteLine($"Printando um objeto da lista {paymentList}");

            var paymentFirst = payments.FirstOrDefault(pay => pay.Id == 7);
            Console.WriteLine($"Printando um item do objeto {paymentFirst.Id}");

            payments.Remove(paymentFirst);

            foreach (var pay in payments)
            {
                Console.WriteLine($"Pagamento removido {pay.Id}");
            }

            //Skip pula o item que vc selecionou
            foreach (var item in payments.Skip(2))
                Console.WriteLine($"Pagamento pulou um item {item.Id}");


            foreach (var item in payments.Take(7))
                Console.WriteLine($"Pagamento pegou um item {item.Id}");

            //Com o AddRange é possivel inserir uma lista dentro de outra lista...            
            // var paidPayments = new List<Payment>();
            // payments.AddRange(payments);

            var exists = payments.Any(exts => exts.Id == 2);
            Console.WriteLine($"O pagamento 2 {exists}.");
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

using System;

namespace GenericsI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person();
            var payment = new Payment();
            var context = new DataContext<Person>();
            context.Save(person);

            //Como o context foi criado do tipo Person, colocando o context payment não roda
            //context.Save(payment);

        }

        public class DataContext<T>
        {
            public void Save(T entity)
            {

            }
        }

        public class Person
        {

        }

        public class Payment
        {

        }

        public class Subscription
        {

        }

    }
}

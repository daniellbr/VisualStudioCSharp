using System;

namespace GenericsII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var persom = new Person();
            var payment = new Payment();
            var subscription = new Subscription();

            var context = new DataContext<IPerson, Payment, Subscription>();
            context.Save(persom);
            context.Save(payment);
            context.Save(subscription);

        }
    }

    //Utilizando mais de um tipo dentro do generico e também inserindo mais de um tipo e 
    //incluindo a condicao WHERE 
    //É possivel utilizar até uma Interface desde que ela seja implementada na classe chamada
    public class DataContext<P, PA, S>
                            where P : IPerson
                            where PA : Payment
                            where S : Subscription
    {
        public void Save(P Person)
        {

        }

        public void Save(PA Payment)
        {

        }

        public void Save(S Subscription)
        {

        }

    }

    public interface IPerson
    {

    }

    public class Person : IPerson
    {

    }

    public class Payment
    {

    }

    public class Subscription
    {

    }


}

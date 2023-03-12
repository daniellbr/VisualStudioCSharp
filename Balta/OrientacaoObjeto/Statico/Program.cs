using System;

namespace Statico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Nao foi necessário instanciar pagamento
            Pagamento.NomeAPI = "Eu tava vacilando";
            Console.WriteLine(Pagamento.NomeAPI);
            Pagamento.NomeAPI = "Quando a classe declarada é estatica, não é necessário instancia-la";

            Console.WriteLine(Pagamento.NomeAPI);

            var nota = new Nota();

            nota.Tipo = "Neste caso foi necessário instanciar";

            Console.WriteLine(nota.Tipo);
        }

        public class Nota
        {
            public string Tipo { get; set; }
        }

        //Se faz necessário criar uma classe estatica quando é criado e utilizado por 
        //multiplos usuarios ou classe diferente de uma classe normal ex pagamento 
        //onde tem que ter um pagamento por cliente entao se faz necessário instanciar a classe

        public static class Pagamento
        {
            public static string NomeAPI { get; set; }
        }
    }
}

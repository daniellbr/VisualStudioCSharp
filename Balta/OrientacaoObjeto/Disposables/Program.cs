using System;

namespace Disposables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dispor = new Dispor();
            dispor.Dispose();

            using (var disporComUsing = new Dispor())
            {
                Console.WriteLine("Abrindo a conexão mas fechando sem chamar o dispose");
            };
        }

        public class Dispor : IDisposable
        {
            public Dispor()
            {
                Console.WriteLine("Abrindo a conexão");
            }

            public void Dispose()
            {
                Console.WriteLine("Finalizando a conexão");
            }
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pessoaA = new Pessoa(1, "Juca de Oliveira");
            var pessoaB = new Pessoa(1, "Juca de Oliveira");

            //Dessa maneira sempre ira retornar false pois esta comparando o 
            //objeto instanciado ou seja um endereco de memoria com outro endereco de memoria
            Console.Write(pessoaA == pessoaB);

            //Aqui retorna True pois analisa o valor interno do objeto ou seja o valor 
            // que existe dentro dele

            //Essa comparação pode ser feita direta como esta ou implementando a interface
            //IEquatable
            Console.Write(pessoaA.Equals(pessoaB));
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public string Nome { get; set; }

        public int Id { get; set; }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public bool Equals(Pessoa pessoaId)
        {
            return Id == pessoaId.Id;
        }
    }
}

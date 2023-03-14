using System;

namespace UpcastDowncast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Conceito de Upcast Pessoa pode herdar os filhos PessoaFisica/PessoaJuridica 
            //Pessoa Fisica e Pessoa Juridica
            var pessoa = new Pessoa();
            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();

            var pessoaFisica = new PessoaFisica();

            pessoaFisica.CPF = "12345";


            Console.WriteLine(pessoa.CPF);

            pessoa.CNPJ = "987654";
            Console.WriteLine(pessoa.CNPJ);

            pessoa.Nome = "Juca";
            Console.WriteLine(pessoa.Nome);

            var pessoaFisica = new PessoaFisica();
            var pessoaJuridica = new PessoaJuridica();

            pessoa = pessoaFisica;

            pessoa.CPF = "122";

            Console.WriteLine(pessoa.CPF);

        }

        public class Pessoa
        {
            public string Nome { get; set; }
        }

        public class PessoaFisica : Pessoa
        {
            public string CPF { get; set; }
        }

        public class PessoaJuridica : Pessoa
        {
            public string CNPJ { get; private set; }
        }

    }
}

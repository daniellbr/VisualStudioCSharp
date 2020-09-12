using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GravarUsandoAdoNet();
            // GravandoUsandoEntity();
            RecuperarProdutos();
        }

        public static void RecuperarProdutos()
        {
            using (var repoConsulta = new LojaContext())
            {
                //IList<Produto> produtos = repoConsulta.Produtos.ToList();
                var produtos = repoConsulta.Produtos.ToList();

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
                Console.ReadLine();
            }
        }
        private static void GravandoUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Super Chef";
            p.Categoria = "Livros";
            p.Preco = 11.55;



            using (var contexto = new LojaContext())//Uma convenção utilizada é o uso da palavra context para referenciar o contexto
            {                                       //Essa classe possui o conceito de persistir todas as classes que necessitam
                contexto.Produtos.Add(p);           //ser persistidas ela é generica servindo para Update, Insert, Select e Delete               
                contexto.SaveChanges();
            }
        }


        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;

        //    using (var repo = new ProdutoDAO()) //Neste caso é representado por uma classe chamada ProdutoDAO 
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
    }
}

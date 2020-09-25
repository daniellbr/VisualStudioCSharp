using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            using (var contexto = new LojaContext())
            {

                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());
                
                var produtos = contexto.Produtos.ToList();
                               
                ExibeEntries(contexto.ChangeTracker.Entries());

                var novoProduto = new Produto()
                {
                    Nome = "Amaciante",
                    Categoria = "limpeza",
                    Preco = 2.44
                };
                contexto.Produtos.Add(novoProduto);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.Produtos.Remove(novoProduto);

                ExibeEntries(contexto.ChangeTracker.Entries());

                var entry = contexto.Entry(novoProduto);
                Console.WriteLine(entry.Entity.ToString() + " - " + entry.State);
                                
                //Existe um outro estado no o DETACHED ele não é mais monitorado pelo banco porém ele ainda existe no contexto

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());
            }
            Console.ReadLine();
        }
        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("==========================================");
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }







        //public static void AtualizarProdutoEntity()
        //{
        //    //Vai incluir pelo menos um registro caso a tabela esteja vazia
        //    InserindoProdutoEntity();
        //    ConsultaProdutosEntity();

        //    //Agora atualiza
        //    using (var repoAtualiza = new IProdutoDAOEntity())
        //    {
        //        Produto primeiroProduto = repoAtualiza.Produtos().First();
        //        primeiroProduto.Nome = "Super Chef Mais ou menos";
        //        primeiroProduto.Preco = 12.65;
        //        repoAtualiza.Atualizar(primeiroProduto);
        //    }

        //    ConsultaProdutosEntity();

        //}
        //public static void ExcluirProdutosEntity()
        //{
        //    using (var repoExcluir = new IProdutoDAOEntity())
        //    {
        //        IList<Produto> produtos = repoExcluir.Produtos().ToList();

        //        foreach (var item in produtos)
        //        {
        //            repoExcluir.Remover(item);
        //        }
        //    }
        //}

        //public static void ConsultaProdutosEntity()
        //{
        //    using (var repoConsulta = new IProdutoDAOEntity())
        //    {
        //        // Criei uma variavel do tipo IList e ela será do tipo Produto onde ela vai receber os dados da tabela
        //        // Pois foi criada a variabel repoConsulta do tipo LojaContext essa variavel está retornando uma lista 
        //        //da LojaContext
        //        //IList<Produto> produtos = repoConsulta.Produtos.ToList();
        //        var produtos = repoConsulta.Produtos();

        //        Console.WriteLine("Foram encontrados {0} produto(s).", produtos.Count);

        //        foreach (var item in produtos)
        //        {
        //            Console.WriteLine(item.Nome);
        //        }
        //        Console.ReadLine();
        //    }
        //}
        //private static void InserindoProdutoEntity()
        //{
        //    Produto produtoIncluir = new Produto();
        //    produtoIncluir.Nome = "Master Chef";
        //    produtoIncluir.Categoria = "Livros";
        //    produtoIncluir.Preco = 11.55;

        //    using (var contexto = new IProdutoDAOEntity())//Uma convenção utilizada é o uso da palavra context para referenciar o contexto
        //    {                                             //Essa classe possui o conceito de persistir todas as classes que necessitam
        //        contexto.Adicionar(produtoIncluir);    //ser persistidas ela é generica servindo para Update, Insert, Select e Delete                               
        //    }
        //}


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

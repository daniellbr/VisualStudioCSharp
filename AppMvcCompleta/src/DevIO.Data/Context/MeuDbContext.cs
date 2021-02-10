using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevIO.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores  { get; set; }

        //Mapeando diretamente no DbContext todos de uma unica vez
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            //Desabilitando o cascade Delete: caso uma tabela pai seja deletada nao deleta os filhos
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) 
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}

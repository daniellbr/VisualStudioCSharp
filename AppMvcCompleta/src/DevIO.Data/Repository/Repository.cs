using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public abstract class Repository<TGenEntity> : IRepository<TGenEntity> where TGenEntity : Entity, new()
    {
        protected readonly MeuDbContext meuDbContext;        

        public Repository(MeuDbContext context)
        {
            meuDbContext = context;
            
        }

        public async Task<IEnumerable<TGenEntity>> Buscar(System.Linq.Expressions.Expression<Func<TGenEntity, bool>> predicate)
        {
            return await meuDbContext.Set<TGenEntity>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TGenEntity> ObterPorId(Guid id)
        {
            return await meuDbContext.Set<TGenEntity>().FindAsync();
        }

        public virtual async Task<List<TGenEntity>> ObterTodos()
        {
            return await meuDbContext.Set<TGenEntity>().ToListAsync();
        }

        public virtual async Task Adicionar(TGenEntity entity)
        {
            meuDbContext.Set<TGenEntity>().Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TGenEntity entity)
        {
            meuDbContext.Set<TGenEntity>().Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            //Desta maneira não é necessário efetuar um acesso ao banco, é criado um tipo generico somente como ID já que todo obj é do tipo Entity
            meuDbContext.Set<TGenEntity>().Remove(new TGenEntity { Id = id});
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await meuDbContext.SaveChangesAsync(); 
        }

        public void Dispose()
        {
            meuDbContext?.Dispose();
        }
    }
}

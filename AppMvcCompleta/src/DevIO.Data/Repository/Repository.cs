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
        protected readonly DbSet<TGenEntity> dbSet;

        public Repository(MeuDbContext context)
        {
            meuDbContext = context;
            dbSet = context.Set<TGenEntity>();
        }

        public async Task<IEnumerable<TGenEntity>> Buscar(System.Linq.Expressions.Expression<Func<TGenEntity, bool>> predicate)
        {
            return await dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TGenEntity> ObterPorId(Guid id)
        {
            return await dbSet.FindAsync();
        }

        public virtual async Task<List<TGenEntity>> ObterTodos()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task Adicionar(TGenEntity entity)
        {
            dbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TGenEntity entity)
        {
            dbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            //Desta maneira não é necessário efetuar um acesso ao banco, é criado um tipo generico somente como ID já que todo obj é do tipo Entity
            dbSet.Remove(new TGenEntity { Id = id});
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

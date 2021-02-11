using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<TGenEntity> : IDisposable where TGenEntity : Entity
    {
        Task Adicionar(TGenEntity entity);

        Task<TGenEntity> ObterPorId(Guid id);

        Task<List<TGenEntity>> ObterTodos();

        Task Atualizar(TGenEntity entity);

        Task Remover(Guid id);

        Task<IEnumerable<TGenEntity>> Buscar(Expression<Func<TGenEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}

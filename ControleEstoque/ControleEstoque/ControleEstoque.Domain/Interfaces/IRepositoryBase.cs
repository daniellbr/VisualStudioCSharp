using ControleEstoque.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ControleEstoque.Domain.Intercafes
{
    public interface IRepositoryBase<TEntity> where TEntity: Entity
    {
        bool Create(TEntity tipoEntity); //Metodo para inserção de registros

        IEnumerable<TEntity> GetAll(); // Cria um metodo que retorna todos os registros

        TEntity GetById(Guid id); //Consulta especifica com um registro somente pelo ID

        bool Update(TEntity entity); // Metodo para atualizar e retorna somente um bool verdadeiro ou falso

        bool Delete(Guid id); // Metodo para deletar um registro a partir de um hasch 
    }
}

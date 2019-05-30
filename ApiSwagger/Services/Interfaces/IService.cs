using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IService<TEntity> where TEntity : BaseEntity
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        TEntity GetById(Guid Id);
        IEnumerable<TEntity> GetAll();
    }
}

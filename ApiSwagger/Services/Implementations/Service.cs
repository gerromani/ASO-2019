using Repositories.Entities;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IRepository<TEntity> repository;

        public Service(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Create(TEntity entity)
        {
            repository.Add(entity);
        }

        public void Delete(Guid id)
        {
            repository.Delete(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(Guid Id)
        {
            return repository.GetById(Id);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}

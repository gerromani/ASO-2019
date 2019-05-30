using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity 
    {
        void Add(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Delete(Guid id);
    }
}

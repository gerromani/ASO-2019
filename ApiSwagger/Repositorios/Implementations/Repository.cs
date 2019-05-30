using NHibernate;
using Repositories.Entities;
using Repositories.Helpers;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private INHibernateHelper DBContext;

        public Repository(INHibernateHelper context)
        {
            this.DBContext = context;
        }

        protected ISession Session
        {
            get
            {
                return DBContext.OpenSession();
            }
        }

        public void Add(T entity)
        {
            Session.Save(entity);
        }

        public void Delete(Guid id)
        {
            Session.Delete(Session.Load<T>(id));
        }

        public IEnumerable<T> GetAll()
        {
            return Session.Query<T>();
        }

        public T GetById(Guid id)
        {
            return Session.Get<T>(id);
        }

        public void Update(T entity)
        {
            Session.Update(entity);
        }
    }
}

using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Repositories.Entities;

namespace Repositories.Helpers
{
    public class NHibernateHelper : INHibernateHelper
    {
        private readonly string connectionString;
        private readonly object lockObject = new object();
        private ISessionFactory sessionFactory;
        private ITransaction _transaction;

        public NHibernateHelper(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionString"];
        }

        public NHibernateHelper()
        {
            connectionString = "Server=localhost;Database=ApiSwagger;Uid=admin;Pwd=T3st4dm1n;SslMode=none";

        }

        private ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    CreateSessionFactory();
                }

                return sessionFactory;
            }
        }

        private void CreateSessionFactory()
        {
            lock (lockObject)
            {
                var fluentConfiguration = Fluently.Configure()
                                                  .Database(MySQLConfiguration.Standard.ConnectionString(connectionString))
                                                  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<BaseEntity>())
                                                  .ExposeConfiguration(BuildSchema);

                sessionFactory = fluentConfiguration.BuildSessionFactory();
            }
        }

        private void BuildSchema(Configuration obj)
        {
            //cfg => new SchemaUpdate(cfg).Execute(false, true)
            if (DbExists(obj))
                return;

            // create schema database
        }

        private bool DbExists(Configuration obj)
        {
            throw new NotImplementedException();
        }

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void BeginTransaction()
        {
            _transaction = SessionFactory.OpenSession().BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                // commit transaction if there is one active
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                // rollback if there was an exception
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                SessionFactory.OpenSession().Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();
            }
            finally
            {
                SessionFactory.OpenSession().Dispose();
            }
        }
    }
}

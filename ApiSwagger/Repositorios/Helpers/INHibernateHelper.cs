using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Helpers
{
    public interface INHibernateHelper
    {
        ISession OpenSession();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}

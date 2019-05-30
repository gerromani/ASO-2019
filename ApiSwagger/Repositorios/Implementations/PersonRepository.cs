using Repositories.Entities;
using Repositories.Helpers;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(INHibernateHelper context)
            : base(context)
        {

        }
    }
}

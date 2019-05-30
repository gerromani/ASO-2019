using Repositories.Entities;
using Repositories.Helpers;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        public TaskRepository(INHibernateHelper context) :
            base(context)
        {

        }
    }
}

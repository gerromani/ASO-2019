using FluentNHibernate.Mapping;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Mappings
{
    public class TaskMap : BaseEntityMap<Task>
    {
        public TaskMap()
        {
            Table("Tasks");
            LazyLoad();
            Map(x => x.State).CustomType<TakenState>();
            Map(x => x.Title);
            Map(x => x.Description);
            References(x => x.AssignedTo);
        }
    }
}

using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Mappings
{
    public class BaseEntityOverride : IAutoMappingOverride<BaseEntity>
    {
        public void Override(AutoMapping<BaseEntity> mapping)
        {
            mapping.Id(x => x.Id)
                   .UnsavedValue(0)
                   .GeneratedBy
                   .Identity();

            mapping.Map(x => x.CreatedOn).Not.Nullable();
        }
    }

}

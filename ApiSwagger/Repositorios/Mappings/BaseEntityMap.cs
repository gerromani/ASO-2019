using FluentNHibernate.Mapping;
using Repositories.Entities;

namespace Repositories.Mappings
{
    public abstract class BaseEntityMap<T> : ClassMap<T> where T : BaseEntity
    {
        public BaseEntityMap()
        {
            Id(x => x.Id).Not.Nullable().GeneratedBy.GuidComb();   
            Map(x => x.CreatedOn).Not.Nullable().Not.Update();
            LazyLoad();
        }
    }
}

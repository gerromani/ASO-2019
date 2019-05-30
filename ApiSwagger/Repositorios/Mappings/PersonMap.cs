using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Mappings
{
    public class PersonMap : BaseEntityMap<Person>
    {
        public PersonMap()
        {
            Table("Persons");
            Map(x => x.Name);
            Map(x => x.CardId);
            Component(x => x.Address, x =>
            {
                x.Map(a => a.AddressLine1).Not.Nullable();
                x.Map(a => a.AddressLine2);
                x.Map(a => a.City);
                x.Map(a => a.PostalCode);
                x.Map(a => a.Region);
            });
        }
    }
}

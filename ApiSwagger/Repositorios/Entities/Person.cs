using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Person : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string CardId { get; set; }
        public virtual Address Address { get; set; }
    }
}

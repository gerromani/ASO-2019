using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; private set; }
        public virtual DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.UtcNow;
        }
    }
}

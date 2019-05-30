using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Address
    {
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Region { get; set; }
    }
}

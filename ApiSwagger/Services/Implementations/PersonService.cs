using Repositories.Entities;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class PersonService : Service<Person>, IPersonService
    {
        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {

        }

        public IEnumerable<Person> GetPersonsByZipCode(string zipCode)
        {
            throw new NotImplementedException();
        }
    }
}

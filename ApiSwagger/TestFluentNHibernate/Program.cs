using Repositories.Entities;
using Repositories.Helpers;
using System;

namespace TestFluentNHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new NHibernateHelper();
            using (var session = helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    var person = new Person()
                    {
                        Address = new Address
                        {
                            AddressLine1 = "Cruz Roja Argentina 100",
                            City = "Cordoba",
                            PostalCode = "5000",
                            Region = "Centro"
                        },
                        CardId = "1453434",
                        Name = "German de la Prueba"
                    };

                    session.SaveOrUpdate(person);
                    transaction.Commit();
                }
                
            }

            Console.Write("Peronsa insertada, chequee base de datos");
            Console.ReadKey();
        }
    }
}

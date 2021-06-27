using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;

namespace Data.Fake
{
    public static class DataFakeClientes
    {
        public static IEnumerable<Client> GenerateClients(int amount)
        {
            var gender = new Faker().PickRandom<Name.Gender>();

            var people = new Faker<Client>("en_US")
                .CustomInstantiator(f => new Client(
                    Guid.NewGuid(),
                    f.Name.FirstName(gender),
                    f.Name.LastName(gender),
                    gender.ToString(),
                    f.Date.Past(80, DateTime.Now.AddYears(-18)),
                    f.Person.Phone,
                    f.Random.Decimal(500, 2000)
                    )
                )
                .RuleFor(c => c.Email, (f, c) =>
                      f.Internet.Email(c.FirstName.ToLower(), c.LastName.ToLower()));

            return people.Generate(amount);
        }   
    }
}
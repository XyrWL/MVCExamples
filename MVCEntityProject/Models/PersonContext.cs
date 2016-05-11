using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEntityProject.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public PersonContext() : base("Choklad")
        {
            Database.SetInitializer<PersonContext>(new PersonInitializer());
        }
    }

    public class PersonInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>()
            {
                new Person() {
                    PersonId = 1,
                    Name = "Freddie Wahlgren",
                    DateOfBirth = new DateTime(1977,01,15),
                    Height = 183.00M,
                    Weight = 70.00M
                },
                new Person() {
                    PersonId = 2,
                    Name = "Lisa Simpson",
                    DateOfBirth = new DateTime(1968,01,15),
                    Height = 213.00M,
                    Weight = 80.00M
                },
                new Person() {
                    PersonId = 3,
                    Name = "Homer Simpson",
                    DateOfBirth = new DateTime(1967,01,1),
                    Height = 163.00M,
                    Weight = 170.00M
                }
            };
            foreach (var person in persons)
                context.Persons.Add(person);

            var addresses = new List<Address>()
            {
                new Address()
                {
                    AddressId = 1,
                    Street = "Kungsgatan, 39",
                    City = "Helsingborg",
                    Zip = "256 01"
                },
                new Address()
                {
                    AddressId = 2,
                    Street = "Lägervägen, 29",
                    City = "Trollhättan",
                    Zip = "567 10"
                },
                new Address()
                {
                    AddressId = 3,
                    Street = "Calle de la Jara, 19",
                    City = "Madrid",
                    Zip = "287 11"
                }
            };

            foreach (var address in addresses)
                context.Addresses.Add(address);

            context.SaveChanges();
        }
    }
}
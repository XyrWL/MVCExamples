using System.Collections.Generic;

namespace MVCEntityProject.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public IList<Person> Persons { get; set; }

        public Address()
        {
            
        }
    }
}
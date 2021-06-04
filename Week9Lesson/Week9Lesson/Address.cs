using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lesson
{
    class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public Address(int streetNumber, string streetName, string city, string postalCode)
        {
            StreetNumber = streetNumber;
            StreetName = streetName;
            City = city;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"Address: {StreetNumber}, {StreetName}, {City}, {PostalCode}";
        }
    }
}

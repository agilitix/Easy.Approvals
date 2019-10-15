using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibTest
{
    class Person
    {
        public string GivenNames { get; set; }
        public string FamilyName { get; set; }
        public string Spouse { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Country { get; set; }
    }
}

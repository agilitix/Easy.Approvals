using System.Collections.Generic;
using ApprovalTests.Reporters;
using NUnit.Framework;
using ObjectApproval;

namespace MyLibTest
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    class ModelTest
    {
        [Test]
        public void Testing()
        {
            var person1 = new Person
                          {
                              GivenNames = "John",
                              FamilyName = "Smith",
                              Spouse = "Jill",
                              Address = new Address
                                        {
                                            Street = "1 Puddle Lane",
                                            Country = "USA"
                                        }
                          };

            var person2 = new Person
                          {
                              GivenNames = "Marianne",
                              FamilyName = "Aguirre"
                          };

            IList<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);

            ObjectApprover.VerifyWithJson(persons);
        }
    }
}

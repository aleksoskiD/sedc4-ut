using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public Person (string firstName, string lastName, int age)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("First name cannot be empty");

            if(age < 0 || age >= 100)
                throw new ArgumentOutOfRangeException("Age is not in the valid range");

            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int Age { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}

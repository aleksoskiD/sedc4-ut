using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pet
    {

        public Pet(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name is null or empty");

            if (age >= 20 || age < 0)
                throw new PetAgeException();

            Age = age;
            Name = name;

        }

        public int Age { get; private set; }
        public string Name { get; private set; }

        public IPetDatabase DataBase { get; set; }

        public bool SaveToDatabase()
        {
            return DataBase.SaveNewPet(this.Name, this.Age);
        }
    }


    public class PetAgeException : ArgumentOutOfRangeException
    {
        public PetAgeException() : base("Age is not in the valid range (0-20]") { }
    }
}

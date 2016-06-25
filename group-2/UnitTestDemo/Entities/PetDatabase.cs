using System;

namespace Entities
{
    public class PetDatabase : IPetDatabase
    {
        public bool SaveNewPet(string name, int age)
        {
            if (name.Length <= 2)
                return false;

            Console.WriteLine($"Saving {name} to database");

            return true;
        }

    }
}
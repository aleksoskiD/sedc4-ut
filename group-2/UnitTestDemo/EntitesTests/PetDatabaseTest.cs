using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitesTests
{
    internal class PetDatabaseTest : IPetDatabase
    {
        public bool IsCalled = false;

        public bool SaveNewPet(string name, int age)
        {
            IsCalled = true;

            if (name.Length <= 2)
                return false;

            return true;
        }
    }
}

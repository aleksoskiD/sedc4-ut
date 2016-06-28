using Entities;

namespace EntitiesTests
{
    internal class PersonDatabaseFake : IPersonDatabase
    {
        public bool WasCalled { get; private set; }
        public bool SaveResult { get; private set; }

        public PersonDatabaseFake(bool saveResult)
        {
            SaveResult = saveResult;
            WasCalled = false;
        }

        public bool Save(string firstName, string lastName, int age)
        {
            WasCalled = true;
            return SaveResult;
        }
    }
}
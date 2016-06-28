using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace EntitiesTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Constructor_ValidValues_Valid_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 38;

            //act
            var weko = new Person(firstName, lastName, age);

            //assert
            Assert.AreEqual(firstName, weko.FirstName);
            Assert.AreEqual(lastName, weko.LastName);
            Assert.AreEqual(age, weko.Age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidFirstName_EmptyString_Exception_Test()
        {
            //arrange
            var firstName = string.Empty;
            var lastName = "Stefanovski";
            var age = 38;

            //act
            var weko = new Person(firstName, lastName, age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        public void Constructor_InvalidFirstName_Null_Exception_Test()
        {
            //arrange
            string firstName = null;
            var lastName = "Stefanovski";
            var age = 38;

            //act
            var weko = new Person(firstName, lastName, age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        public void Constructor_NegativeAge_Exception_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = -45;

            //act
            var weko = new Person(firstName, lastName, age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        public void Constructor_OverflowAge_Exception_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 450;

            //act
            var weko = new Person(firstName, lastName, age);
        }

        [TestMethod]
        public void Constructor_ZeroAge_Valid_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 0;

            //act
            var weko = new Person(firstName, lastName, age);

            //assert
            Assert.AreEqual(firstName, weko.FirstName);
            Assert.AreEqual(lastName, weko.LastName);
            Assert.AreEqual(age, weko.Age);
        }

        [TestMethod]
        public void Constructor_NinetyNineAge_Valid_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 99;

            //act
            var weko = new Person(firstName, lastName, age);

            //assert
            Assert.AreEqual(firstName, weko.FirstName);
            Assert.AreEqual(lastName, weko.LastName);
            Assert.AreEqual(age, weko.Age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        public void Constructor_HundredAge_Exception_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 100;

            //act
            var weko = new Person(firstName, lastName, age);
        }

        [TestMethod]
        public void SaveToDatabase_UnderagePerson_False_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 16;
            var weko = new Person(firstName, lastName, age);
            var database = new PersonDatabaseFake(true);
            weko.Database = database;

            //act
            var result = weko.SaveToDatabase();

            //assert
            Assert.IsFalse(result);
            Assert.IsFalse(database.WasCalled);
        }

        [TestMethod]
        public void SaveToDatabase_OverAgePerson_SuccessSave_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 38;
            var weko = new Person(firstName, lastName, age);
            weko.Database = new PersonDatabaseFake(true);

            //act
            var result = weko.SaveToDatabase();

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SaveToDatabase_OverAgePerson_FailSave_Test()
        {
            //arrange
            var firstName = "Wekoslav";
            var lastName = "Stefanovski";
            var age = 38;
            var weko = new Person(firstName, lastName, age);
            var database = new PersonDatabaseFake(false);
            weko.Database = database;

            //act
            var result = weko.SaveToDatabase();

            //assert
            Assert.IsFalse(result);
            Assert.IsTrue(database.WasCalled);
        }



    }
}

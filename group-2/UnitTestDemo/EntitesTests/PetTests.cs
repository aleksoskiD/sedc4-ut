using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace EntitesTests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void Constructor_ValidValues_Test()
        {
            var name = "Rex";
            var age = 10;

            var rex = new Pet(name, age);

            Assert.AreEqual(age, rex.Age);
            Assert.AreEqual(name, rex.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(PetAgeException))]
        public void Constructor_NegativeAge_Exception_Test()
        {
            var name = "Rex";
            var age = -10;

            var rex = new Pet(name, age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        public void Constructor_EmptyName_Exception_Test()
        {
            var name = string.Empty;
            var age = 10;

            var rex = new Pet(name, age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        public void Constructor_NullName_Exception_Test()
        {
            string name = null;
            var age = 10;

            var rex = new Pet(name, age);
        }

        [TestMethod]
        [ExpectedException(typeof(PetAgeException))]
        public void Constructor_AgeOverflow_Exception_Test()
        {
            string name = "Rex";
            var age = 90;

            var rex = new Pet(name, age);
        }


        [TestMethod]
        public void SaveToDatabase_Valid_Test()
        {
            var name = "Rex";
            var age = 10;
            var rex = new Pet(name, age);
            var database = new PetDatabaseTest();
            rex.DataBase = database;

            var result = rex.SaveToDatabase();

            Assert.IsTrue(result);
            Assert.IsTrue(database.IsCalled);
        }

        [TestMethod]
        public void SaveToDatabase_Invalid_Test()
        {
            var name = "Po";
            var age = 10;
            var rex = new Pet(name, age);
            var database = new PetDatabaseTest();
            rex.DataBase = database;

            var result = rex.SaveToDatabase();

            Assert.IsFalse(result);
            Assert.IsTrue(database.IsCalled);
        }

    }
}

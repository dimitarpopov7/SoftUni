
namespace _1.DataBase.Tests
{
    using _7.UnitTest_Exercises.Interfaces;
    using _7.UnitTest_Exercises.Model;
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class UnitTest1
    {
        private Database db;
        private const string Name = "Person";
        private const int Id = 1;
        private IPerson person;
        [SetUp]
        public void InitiateDb()
        {
            db = new Database();
            person = new Person(Name, Id);
            db.AddPeople(person);

        }

        [Test]
        public void TestIfPersonsDuplicate()
        {
            Assert.Throws<InvalidOperationException>(() => db.AddPeople(person));
        }
        [Test]
        public void TestIfRemoveMethodRemovesThatPerson()
        {
            db.RemovePerson(person);
            Assert.That(db.PersonList.Count == 0);
        }
        [Test]
        public void TestIfUsernameDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername($"{Name}1"));
        }
        [Test]
        public void TestIfNullStringIsAccepted()
        {
            Assert.Throws<ArgumentException>(() => db.FindByUsername(null));
        }
        [Test]
        public void TestIfIdDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => db.FindById(Id+1));
        }
        [Test]
        public void TestIfIdCanBeNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(Id - Id-1));
        }
    }
}

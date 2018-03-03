namespace _1.DataBase.Tests
{
    using NUnit.Framework;
    using _7.UnitTest_Exercises.Model;
    using System;

    [TestFixture]
    public class DataBaseTests
    {
        private Database db;
        [SetUp]
        public void SetUp ()
        {
            this.db = new Database();
        }
        [Test]
        public void TestIfAddMethodAddsElementsToTheCollection()
        {
            int indexBeforeAddition = db.Index;
            this.db.Add(6);
            Assert.That(db.Index > indexBeforeAddition, "Index does not change, therefore number would not be added one afte another.");

        }
        [Test]
        public void TestIfCapacityIs16()
        {
            AddNumbers(16);
            var exception = Assert.Throws<InvalidOperationException>(() => db.Add(1));
            Assert.AreEqual(exception.Message, "Capacity is only 16.", "Capacity goes beyond 16.");
        }

        [Test]
        public void TestIfRemoveMethodRemovesLastElement()
        {
            AddNumbers(8);
            var indexToRemove = db.Index;
            db.Remove();
            Assert.That(indexToRemove > db.Index,"Remove index does not decrease");
        }
        [Test]
        public void TestIfFetchMethodReturnsArray()
        {
            int n = 5;
            AddNumbers(n);
            var fetchArray = db.Fetch();
            Assert.That(fetchArray.Length == n);
        }

        [Test]
        public void TestIfDatabaseCanGetMoreThanOneNumberFromItsCOnstructor()
        {
            this.db = new Database(1, 2, 3);
            var fetchDb = db.Fetch();
            Assert.AreEqual(3, fetchDb[2],"The constructor of database does not add accordingly");
        }

        [Test]
        public void CanNotInitializeDatabaseWithCollectionContainingMoreThanItsCapacity()
        {
            var testCollection = new int[17];

            Assert.Throws<InvalidOperationException>(() => this.db = new Database(testCollection));
        }

        private void AddNumbers(int numberOfNumbersToAdd)
        {
            for (int i = 0; i < numberOfNumbersToAdd; i++)
            {
                db.Add(i);
            }
        }
    }
}

namespace _3.Iterator.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;

    [TestFixture]
    public class ListIteratorTest
    {
        private ListIterator listIterator;
        private string[] initializingCollection;

        [SetUp]
        public void TestInit()
        {
            this.initializingCollection = new string[] { "qwe", "asd", "zxc" };
            this.listIterator = new ListIterator(this.initializingCollection);
        }

        [Test]
        public void InitializationConstructorCannotWorkWithNull()
        {
            Assert.Throws<ArgumentNullException>(() => new ListIterator(null));
        }

        [Test]
        public void MoveReturnsTrueWhenSuccessful()
        {
            Assert.AreEqual(true, this.listIterator.Move());
            Assert.AreEqual(true, this.listIterator.Move());
        }

        [Test]
        public void MoveReturnsFalseWhenThereIsNoMoreElements()
        {
            this.listIterator.Move();
            this.listIterator.Move();

            Assert.AreEqual(false, this.listIterator.Move());
        }

        [Test]
        public void MoveMovesTheInternalIndexToTheNextElementInTheCollection()
        {
            this.listIterator.Move();
            var internalIndexValue = typeof(ListIterator)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "internalIndex")
                .GetValue(this.listIterator);

            Assert.AreEqual(1, internalIndexValue, "Move doesn't influence the internal index");
        }

        [Test]
        public void HasNextReturnsTrueIfThereIsNextElement()
        {
            this.listIterator.Move();

            Assert.IsTrue(this.listIterator.HasNext());
        }

        [Test]
        public void HasNextReturnsFalseIfThereIsNotNextElement()
        {
            this.listIterator.Move();
            this.listIterator.Move();

            Assert.IsFalse(this.listIterator.HasNext());
        }

        [Test]
        public void CannotPrintWithEmptyIterator()
        {
            this.listIterator = new ListIterator(new string[0]);

            var ex = Assert.Throws<InvalidOperationException>(() => this.listIterator.Print());
            Assert.AreEqual("Invalid Operation!", ex.Message, "Attempting to print over empty iterator throws exception with an incorrect message");
        }
    }
}

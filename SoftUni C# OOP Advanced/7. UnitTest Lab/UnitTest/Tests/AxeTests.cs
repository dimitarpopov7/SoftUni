namespace UnitTest.Tests
{
    using Skeleton;
    using Skeleton.Interfaces;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {
        private IWeapon testAxe;
        private ITarget testDummy;

        private const int health=150;
        private const int experience = 10;

        private const int durability=10;
        private const int attack = 10;

        [SetUp]
        public void InitiateAxeAndDummy()
        {
            this.testAxe = new Axe(attack, durability);
            this.testDummy = new Dummy(health, experience);
        }

        [Test]
        public void TestAxeDurability()
        {
            this.testAxe.Attack(this.testDummy);
            Assert.AreEqual(durability-1, testAxe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [Test]
        public void TestIfAxeAttacksBroken()
        {
            string exception=string.Empty;
            try
            {
                for (int i = 0; i < durability + 1; i++)
                {
                    this.testAxe.Attack(this.testDummy);
                }
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
            
            Assert.That(exception, Is.EqualTo("Axe is broken."));
        }
        
    }
}
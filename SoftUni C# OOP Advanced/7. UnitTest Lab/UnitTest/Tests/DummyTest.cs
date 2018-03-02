namespace UnitTest.Tests
{
    using NUnit.Framework;
    using Skeleton;
    using Skeleton.Interfaces;
    using System;

    [TestFixture]
    public class DummyTest
    {
        private IWeapon testAxe;
        private ITarget testDummy;

        private const int attack=5;
        private const int durability=10;
        private const int health=10;
        private const int experienceToGive=10;

        [Test]
        public void TestIsDummyLosesHealth()
        {
            this.testAxe.Attack(testDummy);
            Assert.AreEqual(health - attack, this.testDummy.Health, "Dummy does not lose health.");
        }

        [Test]
        public void TestIfDummyThrowsExceptionWhenDead()
        {
            this.testAxe.Attack(this.testDummy);
            this.testAxe.Attack(this.testDummy);
            var exception = Assert.Throws<InvalidOperationException>(() => this.testAxe.Attack(this.testDummy));
            Assert.That(exception.Message == "Dummy is dead.");
        }

        [Test]
        public void TestIfDummyGivesExperience()
        {
            this.testDummy.TakeAttack(11);
            while (!this.testDummy.IsDead())
            {
                this.testDummy.TakeAttack(attack);
            }
            var experience = this.testDummy.GiveExperience();

            Assert.AreEqual(experienceToGive, experience, "Dead dummy does not give experience");
        }

        [Test]
        public void TestIfDummyDoesNotGiveExperienceWhenAlive()
        {
            var ex=Assert.Throws< InvalidOperationException>(()=>this.testDummy.GiveExperience());
            Assert.AreEqual(ex.Message, "Target is not dead.","Dummy gives experience when dead.");
        }

        [SetUp]
        public void SetWeaponAndDummy()
        {
            this.testDummy = new Dummy(health, experienceToGive);
            this.testAxe = new Axe(attack, durability);
        }
    }
}

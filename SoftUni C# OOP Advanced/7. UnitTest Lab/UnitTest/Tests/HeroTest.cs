namespace UnitTest.Tests
{
    using NUnit.Framework;
    using FakeObjects;
    using Skeleton;
    using Moq;
    using Skeleton.Interfaces;

    [TestFixture]
    public class HeroTest
    {
        private const string Name = "Gosho";

        [Test]
        public void TestIfHeroGainsExperienceFromDeadTarget()
        {
            var fakeWeapon = new FakeWeapon();
            var fakeDummy = new FakeTarget();
            var hero = new Hero(Name, fakeWeapon);

            hero.Attack(fakeDummy);

            Assert.AreEqual(20, hero.Experience, "Hero does not gain experience when dummy dies.");
        }
        [Test]
        public void TestIfHeroGainsExperienceFromDeadTarget_WithMoq()
        {
            var weapon = new Mock<IWeapon>();

            var dummy = new Mock<ITarget>();
            dummy.Setup(t => t.Health).Returns(0);
            dummy.Setup(t => t.IsDead()).Returns(true);

            var hero = new Hero(Name, weapon.Object);
            hero.Attack(dummy.Object);

            Assert.AreEqual(dummy.Object.GiveExperience(), hero.Experience, "Hero does not gain experience when dummy dies.");
        }
    }
}

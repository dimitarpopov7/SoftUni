﻿namespace UnitTest.FakeObjects
{
    using Skeleton.Interfaces;
    public class FakeTarget : ITarget
    {
        public int Health => 0;

        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead() => true;

        public void TakeAttack(int attackPoints)
        {
        }
    }
}

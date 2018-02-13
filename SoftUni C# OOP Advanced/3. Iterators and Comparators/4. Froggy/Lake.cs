namespace _4.Froggy
{
    using System.Collections;
    using System.Collections.Generic;
    public class Lake : IEnumerable<int>
    {
        private readonly int[] stones;

        public Lake(int[] initialStones)
        {
            this.stones = initialStones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Length; i = i + 2)
            {
                yield return stones[i];
            }
            if (stones.Length % 2 == 0)
            {
                for (int i = stones.Length - 1; i >= 1; i = i - 2)
                {
                    yield return stones[i];
                }
            }
            else
            {
                for (int i = stones.Length - 2; i >= 1; i = i - 2)
                {
                    yield return stones[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
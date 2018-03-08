namespace Bubble.Test
{
    using NUnit.Framework;
    using _4.Bubble_Sort;
    [TestFixture]
    public class TestBubble
    {
        [Test]
        [TestCase(2, 1, 4, 3, 5)]
        public void TestIfBubbleSorts(params int[] array)
        {
            var sortedArray = new int[] { 1, 2, 3, 4, 5 };
            var bubble = new Bubble();
            var bubbleArray = bubble.SortBubble(array);

            Assert.AreEqual(sortedArray, bubbleArray, "Bubble Sort does not work.");
        }
    }
}

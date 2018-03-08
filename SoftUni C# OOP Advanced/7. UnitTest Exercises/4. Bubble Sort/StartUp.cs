namespace _4.Bubble_Sort
{
    public class StartUp
    {
        public static void Main()
        {
            var bubble = new Bubble();
            var array = new int[] { 2, 1, 4, 3, 5 };
            array=bubble.SortBubble(array);
            System.Console.WriteLine(string.Join(", ",array));
        }
    }
}

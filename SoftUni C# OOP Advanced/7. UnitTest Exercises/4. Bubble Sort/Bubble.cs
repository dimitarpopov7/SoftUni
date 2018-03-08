namespace _4.Bubble_Sort
{
    public class Bubble
    {

        public int[] SortBubble(int[] array)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int temp = array[i+1];
                    if (array[i] > array[i + 1])
                    {
                        array[i + 1] = array[i];
                        array[i] = temp;
                        isSorted = false;
                    }
                }
            }
            return array;
        }
    }
}
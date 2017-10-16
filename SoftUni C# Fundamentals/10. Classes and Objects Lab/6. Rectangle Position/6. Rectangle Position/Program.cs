namespace _6.Rectangle_Position
{
    using System;
    using System.Linq;
    public class Program
    {
        public class RectPoints
        {
            public int Left { get; set; }

            public int Top { get; set; }
            public int Width { get; set; }
            public int Height {get; set;}

            public int Right => Left + Width;
            public int Bottom => Top + Height;
        }
        public static void Main()
        {
            var smallRectPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            RectPoints recOne =new RectPoints
            {
                Left =smallRectPoints[0],
                Top=smallRectPoints[1],
                Width=smallRectPoints[2],
                Height=smallRectPoints[3]
            };

            var largeRectPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            RectPoints recTwo = new RectPoints
            {
                Left = largeRectPoints[0],
                Top = largeRectPoints[1],
                Width = largeRectPoints[2],
                Height = largeRectPoints[3],
            };
            if (IsInside(recOne,recTwo))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }
        private static bool IsInside(RectPoints smallRec,RectPoints largeRec)
        {
            bool location = false;
            if (smallRec.Left >= largeRec.Left 
                && smallRec.Right <= largeRec.Right 
                && smallRec.Top >= largeRec.Top 
                && smallRec.Bottom <= largeRec.Bottom)
            {
                location = true;
            }
            return location;
        }
    }
}

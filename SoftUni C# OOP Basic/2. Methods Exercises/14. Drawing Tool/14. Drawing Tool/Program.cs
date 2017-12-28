namespace _14.Drawing_Tool
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var type = Console.ReadLine();
            Shape shape = null;
            if (type == "Square")
            {
                int side = int.Parse(Console.ReadLine());
                var square = new Square(side);
                shape = square;
            }
            else
            {
                int width = int.Parse(Console.ReadLine());
                int length = int.Parse(Console.ReadLine());
                var rectangle = new Rectangle(length, width);
                shape = rectangle;
            }
            CorDraw drawer = new CorDraw(shape);
        }
    }
}
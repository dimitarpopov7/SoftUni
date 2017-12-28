namespace _14.Drawing_Tool
{
    using System;
    public class Rectangle : Shape
    {
        private int length;
        private int width;
        
        public int Length
        {
            get { return this.length; }
        }
        public int Width
        {
            get { return this.width; }
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}",'|', new string('-',this.width));
            for (int i = 0; i < this.length-2; i++)
            {
                Console.WriteLine("{0}{1}{0}",'|', new string(' ',this.width));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', this.width));
        }
    }
}

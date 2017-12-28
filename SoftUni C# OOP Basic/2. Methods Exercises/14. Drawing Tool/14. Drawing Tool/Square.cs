namespace _14.Drawing_Tool
{
    using System;
    public class Square : Shape
    {
        private int side;

        public int Side
        {
            get { return this.side; }
        }

        public Square(int side)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('-', this.side));
            for (int i = 0; i < this.side - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string(' ', this.side));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', this.side));
        }
    }
}

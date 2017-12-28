namespace _14.Drawing_Tool
{
    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            this.Draw(shape);
        }
        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }
}

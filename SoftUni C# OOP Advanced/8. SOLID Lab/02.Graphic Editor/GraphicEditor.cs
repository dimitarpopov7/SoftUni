namespace _02.Graphic_Editor
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            System.Console.WriteLine(shape.Draw());
        }
    }
}
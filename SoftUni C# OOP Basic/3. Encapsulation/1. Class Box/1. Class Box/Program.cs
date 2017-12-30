namespace _1.Class_Box
{
    using System;
    using System.Linq;
    using System.Reflection;
    public class Program
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            var length=double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var box = new Box(length,width,height);
            Console.WriteLine(box.SurfaceArea());
            Console.WriteLine(box.LateralSurfaceArea());
            Console.WriteLine(box.Volume());
        }
    }
}
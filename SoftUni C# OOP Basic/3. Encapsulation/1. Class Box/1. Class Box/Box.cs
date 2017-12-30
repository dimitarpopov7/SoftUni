namespace _1.Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length,double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string SurfaceArea()
        {
            return $"Surface Area - {(2*this.length*this.width+2*this.length*this.height+2*this.width*this.height):f2}";
        }
        public string LateralSurfaceArea()
        {
            return $"Lateral Surface Area - {(2 * this.length * this.height + 2 * this.width * this.height):f2}";
        }
        public string Volume()
        {
            return $"Volume - {(this.length*this.width*this.height):f2}";
        }
    }
}
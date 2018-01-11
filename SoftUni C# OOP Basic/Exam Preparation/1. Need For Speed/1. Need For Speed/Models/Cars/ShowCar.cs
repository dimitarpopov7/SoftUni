namespace _1.Need_For_Speed
{
    using System;
    public class ShowCar : Car
    {
        private int stars;

        public int Stars
        {
            get { return this.stars; }
            set { this.stars = value; }
        }

        public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability,int stars=0) : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
        {
            this.Stars = stars;
        }
        public override void TuneCar(int tuneIndex, string addOn)
        {
            base.TuneCar(tuneIndex, addOn);
            this.Stars+=tuneIndex;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}{this.Stars} *";
        }
    }
}
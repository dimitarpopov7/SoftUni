namespace _5.Mordor_s_Cruelty_Plan_FP_.Foods
{
    public abstract class Food
    {
        public Food(int pointsOfHappyiness)
        {
            this.PointsOfHappiness = pointsOfHappyiness;
        }
        public int PointsOfHappiness { get; set; }
    }
}

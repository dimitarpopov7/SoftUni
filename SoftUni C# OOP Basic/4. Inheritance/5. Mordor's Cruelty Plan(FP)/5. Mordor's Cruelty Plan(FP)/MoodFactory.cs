namespace _5.Mordor_s_Cruelty_Plan_FP_
{
    using Moods;
    public class MoodFactory
    {
        public static Mood GetMood(int points)
        {
            
            if (points < 5)
            {
               return new Angry();
            }
            else if (points < 1 && points > -6)
            {
               return new Sad();
            }
            else if (points < 16 && points > 0)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
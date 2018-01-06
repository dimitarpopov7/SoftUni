namespace _5.Mordor_s_Cruelty_Plan_FP_
{
    using Foods;
    public class FoodFactory
    {
        
        public static Food GetPoints(string food)
        {
            switch (food)
            {
                case "cram":
                    return new Cram();
                case "melon":
                    return new Melon();
                case "mushrooms":
                    return new Mushrooms();
                case "honeycake":
                    return new HoneyCake();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();                   
                default:
                    return new EverythingElse();
            }
        }
	
	}
}
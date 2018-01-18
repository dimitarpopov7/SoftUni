namespace _7.Food_Shortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {            
            var citizensRebalsList = new List<Buyer>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var citizenRebalInfo = Console.ReadLine().Split().ToList() ;
                if (citizenRebalInfo.Count == 4)
                {
                    var newCitizen = new Citizen(citizenRebalInfo[0], int.Parse(citizenRebalInfo[1]), citizenRebalInfo[2], citizenRebalInfo[3]);
                    citizensRebalsList.Add(newCitizen);
                }
                else
                {
                    var newRebal = new Rebal(citizenRebalInfo[0], int.Parse(citizenRebalInfo[1]), citizenRebalInfo[2]);
                    citizensRebalsList.Add(newRebal);
                }
            }
            var name = Console.ReadLine();
            while (name!= "End")
            {
                var currentCitizenRebal = citizensRebalsList.FirstOrDefault(x=>x.Name==name);
                if (currentCitizenRebal != null)
                {
                    currentCitizenRebal.BuyFood();
                }                
                name = Console.ReadLine();
            }
            Console.WriteLine(citizensRebalsList.Sum(x=>x.Food));
        }
    }
}

namespace _5.Pizza_Calories
{
    using System;
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private double calories;
        private double modifier;
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.flourType = flourType;
            this.bakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.Modifier = modifier;
            this.Calories = calories;
        }
        public int Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
        public double Modifier
        {
            get { return this.modifier; }
            private set
            {
                if (this.flourType != "White" &&this.flourType!= "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else if (this.flourType == "White")
                {
                    value = 1.5;
                }
                else if (this.flourType == "Wholegrain")
                {
                    value = 1.0;
                }
                this.modifier = value;
            }
        }
        public double Calories
        {
            get { return this.calories; }
            private set
            {
                if(this.bakingTechnique!="crispy"&& this.bakingTechnique != "chewy" && this.bakingTechnique != "homemade"
                    &&this.bakingTechnique != "Crispy" && this.bakingTechnique != "Chewy" && this.bakingTechnique != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else if (this.bakingTechnique == "crispy"||this.bakingTechnique=="Crispy")
                {
                    value =2* 0.9 * Modifier * Weight;
                }
                else if (this.bakingTechnique == "chewy"|| this.bakingTechnique == "Chewy")
                {
                    value = 2*1.1 * Modifier * Weight;
                }
                else if (this.bakingTechnique == "homemade"|| this.bakingTechnique == "Homemade")
                {
                    value = 2*1.0 * Modifier * Weight;
                }
                this.calories = value;
            }
        }
    }
}
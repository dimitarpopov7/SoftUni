namespace _9.Pizza_Time
{
    using System.Collections.Generic;
    public class Pizza
    {
        private string name;
        private int group;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Group
        {
            get { return this.group; }
            set { this.group = value; }
        }
        public Pizza(string name,int group)
        {
            this.name = name;
            this.group = group;
        }
        public SortedDictionary<int, List<string>> SortPizzas(List<Pizza> pizzas)
        {
            var pizzaGroup = new SortedDictionary<int,List<string>>();
            foreach (var pizza in pizzas)
            {
                if (!pizzaGroup.ContainsKey(pizza.Group))
                {
                    var pizzaList = new List<string>() { pizza.Name };
                    pizzaGroup[pizza.Group] = pizzaList;
                }
                else
                {
                    pizzaGroup[pizza.Group].Add(pizza.Name);
                }
            }
            return pizzaGroup;
        }
    }
}

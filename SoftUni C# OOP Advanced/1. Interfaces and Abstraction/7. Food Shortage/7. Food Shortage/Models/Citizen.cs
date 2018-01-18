namespace _7.Food_Shortage
{
    public class Citizen : Buyer
    {
        public Citizen(string name, int age,string id,string birthDay) : base(name, age)
        {
            this.ID = id;
            this.BirthDay = birthDay;
        }

        public string ID { get; private set; }
        
        public string BirthDay { get; private set; }        

       

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }    
}

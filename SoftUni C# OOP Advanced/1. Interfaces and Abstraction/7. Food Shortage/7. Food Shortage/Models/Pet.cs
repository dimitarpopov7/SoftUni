namespace _7.Food_Shortage
{
    public class Pet : IBirthDayAble
    {
        public string BirthDay { get; private set; }
        public string Name { get; private set; }
        public Pet(string name, string birthDay)
        {
            this.BirthDay = birthDay;
            this.Name = name;
        }
    }
}

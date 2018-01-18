namespace _7.Food_Shortage
{
    public class Robot : IId
    {
        public string ID { get; private set; }
        public string Model { get; set; }
        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }
    }
}

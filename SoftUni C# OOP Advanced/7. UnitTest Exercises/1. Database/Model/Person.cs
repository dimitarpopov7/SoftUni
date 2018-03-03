namespace _7.UnitTest_Exercises.Model
{
    using _7.UnitTest_Exercises.Interfaces;

    public class Person:IPerson
    {
        private string username;
        private int id;

        public Person(string username, int id)
        {
            this.Username = username;
            this.Id = id;
        }

        public string Username { get => username;  set => username = value; }
        public int Id { get => id;  set => id = value; }
    }
}

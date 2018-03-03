namespace _7.UnitTest_Exercises
{
    using Model;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var person = new Person("dsa", 1);
            var db = new Database();
            db.AddPeople(person);

            var newPerosn=db.FindByUsername("dsa");
            Console.WriteLine(newPerosn.Id);
        }
    }
}

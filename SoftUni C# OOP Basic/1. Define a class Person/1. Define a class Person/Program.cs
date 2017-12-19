namespace _1.Define_a_Class_Person
{
    using System;
    using System.Reflection;
    public class Define_class_Person
    {
        public static void Main()
        {
            var pesho = new Person("Pesho", 20);
            var gosho = new Person("Gosho", 18);
            var stamat = new Person("stamat", 43);

            Type personType = typeof(Person);
            PropertyInfo[] fields = personType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
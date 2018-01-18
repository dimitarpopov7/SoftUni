namespace _4.Telephony
{
    using System;
    using System.Linq;
    public interface IPhone
    {
        string Model { get; }
        string Call(string phone);
    }
    public interface ISmartPhone : IPhone
    {
        string Browsing(string url);
    }
    public class SmartPhone : ISmartPhone
    {
        public SmartPhone(string model)
        {
            this.Model = model;
        }

        public string Model { get; private set; }
        
        public string Browsing(string url)
        {
            if (!url.Any(c => char.IsDigit(c)))
            {
                return $"Browsing: {url}!";
            }
            else
            {
                throw new ArgumentException("Invalid URL!");
            }
        }
        public string Call(string phone)
        {
            if (!phone.Any(c => char.IsLetter(c)))
            {
                return $"Calling... {phone}";
            }
            else
            {
                throw new ArgumentException("Invalid number!");
            }
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            var phoneBook = Console.ReadLine().Split().ToList();
            var newPhone = new SmartPhone("SmartPhone");
            try
            {
                foreach (var num in phoneBook)
                {
                    Console.WriteLine(newPhone.Call(num));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            var urls = Console.ReadLine().Split().ToList();
            try
            {
                foreach (var url in urls)
                {
                    Console.WriteLine(newPhone.Browsing(url)) ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
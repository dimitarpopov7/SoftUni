namespace _7.Equality_Logic
{
    using System.Collections.Generic;
    public class ComparePersons : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.CompareTo(y) == 0;
        }

        public int GetHashCode(Person person)
        {
            /**
            var something = $"{person.Name} {person.Age}".GetHashCode();
            made that only to see what is the hascode.
            Console.WriteLine(neshto); create the hashcode as string so that if the two strings
            => the people will be equal and they should not be recorded in the collections fot this problem.
            **/
            return $"{person.Name} {person.Age}".GetHashCode();
        }
    }
}

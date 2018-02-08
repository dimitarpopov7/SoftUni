namespace _1.Generic_Box
{
    using System;
    public class Box<T>
        where T:IComparable<T>
    {
        public Box()
        {
            this.Value = default(T);
        }
       
        public Box(T value)
        {
            this.Value = value;    
        }
        public T Value { get; set; }
                
        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}"; 
        }
    }
}

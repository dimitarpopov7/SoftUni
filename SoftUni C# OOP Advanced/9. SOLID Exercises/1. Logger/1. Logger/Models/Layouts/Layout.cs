namespace _1.Logger.Models.Layouts
{
    using Interfaces;
    using System.Collections.Generic;

    public abstract class Layout:ILayout
    {
        public abstract string Format(SortedDictionary<int,string[]> info,int numberOfLinesToTake);
    }
}

namespace _8.Military_Elite.Interfaces
{
    using System.Collections.Generic;
    using Repairs;
    interface IEngineer:ISpecialSoldier
    {
        List<Repair> Repairs { get; }
    }
}

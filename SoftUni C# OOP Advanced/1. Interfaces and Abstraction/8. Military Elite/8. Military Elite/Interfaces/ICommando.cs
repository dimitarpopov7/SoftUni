using System.Collections.Generic;

namespace _8.Military_Elite.Interfaces
{
    using Missions;
    interface ICommando:ISpecialSoldier
    {
        List<Mission> Missions { get; }
    }
}
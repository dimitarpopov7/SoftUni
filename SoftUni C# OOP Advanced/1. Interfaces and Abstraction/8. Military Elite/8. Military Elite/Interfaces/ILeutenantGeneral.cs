namespace _8.Military_Elite.Interfaces
{
    using System.Collections.Generic;
    public interface ILeutenantGeneral : ISoldier,IPrivate
    {
        List<IPrivate> Privates { get; }
    }
}
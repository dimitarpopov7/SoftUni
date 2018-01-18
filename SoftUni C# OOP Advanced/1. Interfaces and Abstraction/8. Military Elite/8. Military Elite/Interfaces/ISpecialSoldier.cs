namespace _8.Military_Elite.Interfaces
{
    interface ISpecialSoldier:ISoldier,IPrivate
    {
        string Corps { get; }
    }
}
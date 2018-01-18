namespace _9.Collection_Hierarchy.Interfaces
{
    /// <summary>
    /// This interface combines IAddable and IRemovable and also adds the countable property.
    /// </summary>
    public interface ICountable:IAddable,IRemovable
    {
        int Used { get; }
    }
}

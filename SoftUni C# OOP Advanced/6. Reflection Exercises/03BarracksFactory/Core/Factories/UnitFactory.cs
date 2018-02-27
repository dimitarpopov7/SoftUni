namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string namespaceAsString = "_03BarracksFactory.Models.Units";
        public IUnit CreateUnit(string unitType)
        {
            Type classType = Type.GetType($"{namespaceAsString}.{unitType}");
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
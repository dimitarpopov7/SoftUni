﻿namespace _03BarracksFactory.Core.Commands
{
    using Contracts;
    using Attributes;
    public class AddCommand : Command
    {
        [Inject]
        private IUnitFactory unitFactory;
        [Inject]
        private IRepository repository;

        public AddCommand(string[] data) : base(data)
        {
        }
        
        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}

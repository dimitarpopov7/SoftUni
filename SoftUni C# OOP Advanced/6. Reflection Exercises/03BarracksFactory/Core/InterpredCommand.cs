namespace _03BarracksFactory.Core
{
    using _03BarracksFactory.Attributes;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class InterpredCommand : ICommandInterpreter
    {
        private const string namespaceCommands = "_03BarracksFactory.Core.Commands";

        private IRepository repository;
        private IUnitFactory unitFactory;

        public InterpredCommand(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string fullCommandName = $"{commandName.First().ToString().ToUpper() + commandName.Substring(1)}Command";
            Type commandType = Type.GetType($"{namespaceCommands}.{fullCommandName}");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            IExecutable command = (IExecutable)Activator.CreateInstance(commandType, new[] { data });

            this.InjectDependancies(command);
            return command;
        }

        private void InjectDependancies(IExecutable command)
        {
            Type injectionType = typeof(InjectAttribute);

            IEnumerable<FieldInfo> fieldsForInjection = command.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttributes().Any(a => a.GetType() == injectionType));

            IEnumerable<FieldInfo> interpreterFields = this.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo fieldForInjection in fieldsForInjection)
            {
                fieldForInjection.SetValue(command, interpreterFields
                    .First(f => f.FieldType == fieldForInjection.FieldType)
                    .GetValue(this));
            }
        }
    }
}
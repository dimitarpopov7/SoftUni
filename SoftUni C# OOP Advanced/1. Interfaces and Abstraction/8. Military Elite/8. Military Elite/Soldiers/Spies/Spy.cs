using System;

namespace _8.Military_Elite.Soldiers.Spies
{
    public class Spy : Soldier
    {
        private string codeNumber;

        public Spy(string firstName, string lastName, string id, string codeNumber) : base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Code Number: {this.CodeNumber}";
        }
        public string CodeNumber
        {
            get { return this.codeNumber; }
            private set { this.codeNumber = value; }
        }
    }
}
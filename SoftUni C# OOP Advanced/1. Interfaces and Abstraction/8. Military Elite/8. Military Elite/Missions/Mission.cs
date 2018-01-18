namespace _8.Military_Elite.Missions
{
    using System;
    using Interfaces;
    public class Mission : IMission
    {
        private string codeName;
        private string state;
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
        public void CompleteMission()
        {

        }
        public string CodeName
        {
            get { return this.codeName; }
            private set { this.codeName = value; }
        }
        public string State
        {
            get { return this.state; }
            private set
            {
                if (value !="inProgress"&&value!="finished")
                {
                    throw new ArgumentException("Invalid Mission.");
                }
                this.state = value;
            }
        }
    }
}
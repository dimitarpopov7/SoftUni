namespace _9.Traffic_Lights.Model
{
    using Enums;
    public class TrafficLight
    {
        public Signals Signal { get; set; }
        public int signalIndex;
        public TrafficLight(Signals signal)
        {
            this.Signal = signal;
            this.signalIndex = (int)signal;
        }
        public void ChangeLight()
        {
            if (signalIndex + 1 > 2)
            {
                this.Signal = (Signals)0;
                this.signalIndex = 0;
            }
            else
            {
                this.Signal = (Signals)signalIndex + 1;
                this.signalIndex += 1;
            }
        }
        public override string ToString()
        {
            return this.Signal.ToString();
        }
    }
}
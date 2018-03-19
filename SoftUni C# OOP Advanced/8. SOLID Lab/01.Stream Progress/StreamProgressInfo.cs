namespace _01.Stream_Progress
{
    using Interfaces;
    public class StreamProgressInfo
    {
        private IStream file;

        public StreamProgressInfo(IStream file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}
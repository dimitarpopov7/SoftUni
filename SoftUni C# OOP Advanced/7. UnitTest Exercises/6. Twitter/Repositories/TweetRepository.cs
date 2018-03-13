namespace _6.Twitter.Repositories
{
    using System.IO;
    using Interfaces;
    using System;

    public class TweetRepository : ITweetRepository
    {
        private const string server = "Server.txt";
        private const string separator = "<SEPARATOR>";
        private readonly string directoryPath = Path.Combine(Environment.CurrentDirectory, server);

        public void SaveTweet(string tweet)
        {
            File.AppendAllText(this.directoryPath, $"{tweet} {separator}");    
        }
    }
}

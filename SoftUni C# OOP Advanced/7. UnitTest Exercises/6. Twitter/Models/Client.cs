namespace _6.Twitter.Models
{
    using System;
    using Interfaces;
    public class Client : IClient
    {
        private ITweetRepository repository;

        public Client(ITweetRepository repository)
        {
            this.repository = repository;
        }
        public void SendTweetToClient(string tweet)
        {
            this.repository.SaveTweet(tweet);
        }

        public void WriteTweet(string tweet)
        {
            Console.WriteLine(tweet);
        }
    }
}

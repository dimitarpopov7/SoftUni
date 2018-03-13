namespace _6.Twitter.Models
{
    using Interfaces;
    public class Tweet : ITweet
    {
        private IClient client;

        public Tweet(IClient client)
        {
            this.client = client;
        }

        public void Retrive(string message)
        {
            this.client.SendTweetToClient(message);
            this.client.WriteTweet(message);
        }
    }
}

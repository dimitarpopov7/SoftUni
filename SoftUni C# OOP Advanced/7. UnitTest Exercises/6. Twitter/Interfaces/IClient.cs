namespace _6.Twitter.Interfaces
{
    public interface IClient
    {
        void WriteTweet(string tweet);

        void SendTweetToClient(string tweet);
    }
}

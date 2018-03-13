namespace _6.Twitter.Test
{
    using NUnit.Framework;
    using Moq;
    using Interfaces;
    using Models;
    [TestFixture]
    public class ClientTest
    {
        private const string Tweet = "Test";
        [Test]
        public void TestMethod1()
        {
            var tweetRepo = new Mock<ITweetRepository>();
            tweetRepo.Setup(tr=>tr.SaveTweet(It.IsAny<string>()));

            var client = new Client(tweetRepo.Object);

            client.SendTweetToClient(Tweet);

            tweetRepo.Verify(tr => tr.SaveTweet(It.Is<string>(s => s == Tweet)), Times.Once, "Message is not send to the server.");
        }
    }
}

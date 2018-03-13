namespace _6.Twitter.Test
{
    using NUnit.Framework;
    using Interfaces;
    using Models;
    using Moq;
    [TestFixture]
    public class TwitterTest
    {
        [Test]
        public void TestIfClientWritesMsg()
        {
            var client = new Mock<IClient>();
            client.Setup(c => c.WriteTweet(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            tweet.Retrive("Test");

            client.Verify(c => c.WriteTweet(It.IsAny<string>()), Times.Once, "Tweet does not invoke its client to write the message");
        }
        [Test]
        public void TestIfMsgWasSentToServer()
        {
            var client = new Mock<IClient>();
            client.Setup(c => c.SendTweetToClient(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            tweet.Retrive("Test");

            client.Verify(c => c.SendTweetToClient(It.IsAny<string>()), Times.Once, "Tweet does not invoke its client send the message to the server");
        }
    }
}

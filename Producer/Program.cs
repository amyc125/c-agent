using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        //Establish inital connection to kafka cluster
        private const string BootstrapServer = "127.0.0.1:9092";
        private const string TopicName = "events";

        private static async Task Main()
        {
            var producer = new Producer(BootstrapServer);
            await producer.StartSendingMessages(TopicName);
        }
    }
}

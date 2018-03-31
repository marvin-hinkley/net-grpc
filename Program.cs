using System;
using Person;
using Grpc.Core;
using static Person.PersonService;

namespace net_grpc
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "127.0.0.1:3000";
            var channel = new Channel(host, ChannelCredentials.Insecure);

            try
            {
                var client = new PersonServiceClient(channel);

                var message = client.Speak(new Person.Void());
                Console.WriteLine(message.Value);

                client.DyeHair(new Person.ColorMessage{Color = "Green"});
                message = client.Speak(new Person.Void());
                Console.WriteLine(message.Value);
            }
            finally
            {
                channel.ShutdownAsync().Wait();
            }
        }
    }
}

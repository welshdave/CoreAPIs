namespace StringLengthClient
{
    using System;
    using System.IO;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Grpc.Core;

    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                Channel channel = new Channel("127.0.0.1:5000", 
                    ChannelCredentials.Insecure);
                var client = new StringLengthService.StringLengthServiceClient(channel);

                using (var call = client.StringLength())
                {
                    var responseReaderTask = Task.Run(async () =>
                    {
                        while (await call.ResponseStream.MoveNext(CancellationToken.None))
                        {
                            var response = call.ResponseStream.Current;
                            Console.WriteLine($"{response.Word} : {response.Len}");
                        }
                    });

                    using (var reader = File.OpenText("words.txt"))
                    {
                        var s = string.Empty;
                        while((s = reader.ReadLine()) != null) { 
                            var word = new StringLengthRequest {Word = s};
                            await call.RequestStream.WriteAsync(word);
                        }
                    }

                    await call.RequestStream.CompleteAsync();
                    await responseReaderTask;
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine($"RPC Failed: {e.Message}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

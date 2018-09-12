namespace StringLengthServer
{
    using System;
    using System.Threading.Tasks;
    using Grpc.Core;

    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            await RunServer();
        }

        private static async Task RunServer()
        {
            var server = new Server
            {
                Ports = {{"127.0.0.1", 5000, ServerCredentials.Insecure}},
                Services = {StringLengthService.BindService(
                    new StringLengthServiceImpl())}
            };

            server.Start();

            Console.WriteLine("StringLengthServer running");
            Console.WriteLine("Press any key to stop the server");
            Console.ReadKey();

            await server.ShutdownAsync();
        }
    }
}
namespace StringLengthServer
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Grpc.Core;

    internal class StringLengthServiceImpl : 
        StringLengthService.StringLengthServiceBase
    {
        public override async Task StringLength(
            IAsyncStreamReader<StringLengthRequest> requestStream,
            IServerStreamWriter<StringLengthReply> responseStream, 
            ServerCallContext context)
        {
            while (await requestStream.MoveNext(CancellationToken.None))
            {
                var s = requestStream.Current;
                Console.Out.WriteLine(s);
                await responseStream.WriteAsync(new StringLengthReply 
                {
                    Word = s.Word, Len = s.Word.Length
                });
            }
        }
    }
}
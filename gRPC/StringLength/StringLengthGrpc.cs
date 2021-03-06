// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StringLength.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class StringLengthService
{
  static readonly string __ServiceName = "StringLengthService";

  static readonly grpc::Marshaller<global::StringLengthRequest> __Marshaller_StringLengthRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::StringLengthRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::StringLengthReply> __Marshaller_StringLengthReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::StringLengthReply.Parser.ParseFrom);

  static readonly grpc::Method<global::StringLengthRequest, global::StringLengthReply> __Method_StringLength = new grpc::Method<global::StringLengthRequest, global::StringLengthReply>(
      grpc::MethodType.DuplexStreaming,
      __ServiceName,
      "StringLength",
      __Marshaller_StringLengthRequest,
      __Marshaller_StringLengthReply);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::StringLengthReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of StringLengthService</summary>
  public abstract partial class StringLengthServiceBase
  {
    public virtual global::System.Threading.Tasks.Task StringLength(grpc::IAsyncStreamReader<global::StringLengthRequest> requestStream, grpc::IServerStreamWriter<global::StringLengthReply> responseStream, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for StringLengthService</summary>
  public partial class StringLengthServiceClient : grpc::ClientBase<StringLengthServiceClient>
  {
    /// <summary>Creates a new client for StringLengthService</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public StringLengthServiceClient(grpc::Channel channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for StringLengthService that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public StringLengthServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected StringLengthServiceClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected StringLengthServiceClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    public virtual grpc::AsyncDuplexStreamingCall<global::StringLengthRequest, global::StringLengthReply> StringLength(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return StringLength(new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncDuplexStreamingCall<global::StringLengthRequest, global::StringLengthReply> StringLength(grpc::CallOptions options)
    {
      return CallInvoker.AsyncDuplexStreamingCall(__Method_StringLength, null, options);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override StringLengthServiceClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new StringLengthServiceClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(StringLengthServiceBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_StringLength, serviceImpl.StringLength).Build();
  }

}
#endregion

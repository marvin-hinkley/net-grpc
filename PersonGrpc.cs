// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: person.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Person {
  public static partial class PersonService
  {
    static readonly string __ServiceName = "person.PersonService";

    static readonly grpc::Marshaller<global::Person.Void> __Marshaller_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Person.Void.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Person.SpeakMessage> __Marshaller_SpeakMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Person.SpeakMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Person.ColorMessage> __Marshaller_ColorMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Person.ColorMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Person.PersonMessage> __Marshaller_PersonMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Person.PersonMessage.Parser.ParseFrom);

    static readonly grpc::Method<global::Person.Void, global::Person.SpeakMessage> __Method_Speak = new grpc::Method<global::Person.Void, global::Person.SpeakMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Speak",
        __Marshaller_Void,
        __Marshaller_SpeakMessage);

    static readonly grpc::Method<global::Person.ColorMessage, global::Person.Void> __Method_DyeHair = new grpc::Method<global::Person.ColorMessage, global::Person.Void>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DyeHair",
        __Marshaller_ColorMessage,
        __Marshaller_Void);

    static readonly grpc::Method<global::Person.Void, global::Person.PersonMessage> __Method_GetPerson = new grpc::Method<global::Person.Void, global::Person.PersonMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPerson",
        __Marshaller_Void,
        __Marshaller_PersonMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Person.PersonReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PersonService</summary>
    public abstract partial class PersonServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Person.SpeakMessage> Speak(global::Person.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Person.Void> DyeHair(global::Person.ColorMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Person.PersonMessage> GetPerson(global::Person.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PersonService</summary>
    public partial class PersonServiceClient : grpc::ClientBase<PersonServiceClient>
    {
      /// <summary>Creates a new client for PersonService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PersonServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PersonService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PersonServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PersonServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PersonServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Person.SpeakMessage Speak(global::Person.Void request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Speak(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Person.SpeakMessage Speak(global::Person.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Speak, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Person.SpeakMessage> SpeakAsync(global::Person.Void request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SpeakAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Person.SpeakMessage> SpeakAsync(global::Person.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Speak, null, options, request);
      }
      public virtual global::Person.Void DyeHair(global::Person.ColorMessage request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DyeHair(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Person.Void DyeHair(global::Person.ColorMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DyeHair, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Person.Void> DyeHairAsync(global::Person.ColorMessage request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DyeHairAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Person.Void> DyeHairAsync(global::Person.ColorMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DyeHair, null, options, request);
      }
      public virtual global::Person.PersonMessage GetPerson(global::Person.Void request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetPerson(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Person.PersonMessage GetPerson(global::Person.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPerson, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Person.PersonMessage> GetPersonAsync(global::Person.Void request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetPersonAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Person.PersonMessage> GetPersonAsync(global::Person.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPerson, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PersonServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PersonServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PersonServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Speak, serviceImpl.Speak)
          .AddMethod(__Method_DyeHair, serviceImpl.DyeHair)
          .AddMethod(__Method_GetPerson, serviceImpl.GetPerson).Build();
    }

  }
}
#endregion

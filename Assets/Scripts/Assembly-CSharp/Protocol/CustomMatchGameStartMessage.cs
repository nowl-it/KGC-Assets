using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CustomMatchGameStartMessage : IMessage<CustomMatchGameStartMessage>, IMessage, IEquatable<CustomMatchGameStartMessage>, IDeepCloneable<CustomMatchGameStartMessage>, IBufferMessage
	{
		private static readonly MessageParser<CustomMatchGameStartMessage> _parser;

		private UnknownFieldSet _unknownFields;

		public const int StartFieldNumber = 1;

		private bool start_;

		public const int ReadyUsersFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_readyUsers_codec;

		private readonly RepeatedField<int> readyUsers_;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CustomMatchGameStartMessage> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Start
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ReadyUsers => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CustomMatchGameStartMessage()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CustomMatchGameStartMessage(CustomMatchGameStartMessage other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CustomMatchGameStartMessage Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return false;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(CustomMatchGameStartMessage other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return 0;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return 0;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomMatchGameStartMessage other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}
	}
}

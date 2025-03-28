using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DevSetEnemyBerserkValueMessage : IMessage<DevSetEnemyBerserkValueMessage>, IMessage, IEquatable<DevSetEnemyBerserkValueMessage>, IDeepCloneable<DevSetEnemyBerserkValueMessage>, IBufferMessage
	{
		private static readonly MessageParser<DevSetEnemyBerserkValueMessage> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ValueFieldNumber = 1;

		private int value_;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DevSetEnemyBerserkValueMessage> Parser => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DevSetEnemyBerserkValueMessage()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevSetEnemyBerserkValueMessage(DevSetEnemyBerserkValueMessage other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevSetEnemyBerserkValueMessage Clone()
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
		public bool Equals(DevSetEnemyBerserkValueMessage other)
		{
			return false;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
		public void MergeFrom(DevSetEnemyBerserkValueMessage other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}
	}
}

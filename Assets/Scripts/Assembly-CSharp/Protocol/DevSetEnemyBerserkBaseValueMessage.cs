using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DevSetEnemyBerserkBaseValueMessage : IMessage<DevSetEnemyBerserkBaseValueMessage>, IMessage, IEquatable<DevSetEnemyBerserkBaseValueMessage>, IDeepCloneable<DevSetEnemyBerserkBaseValueMessage>, IBufferMessage
	{
		private static readonly MessageParser<DevSetEnemyBerserkBaseValueMessage> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ValueFieldNumber = 1;

		private int value_;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DevSetEnemyBerserkBaseValueMessage> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
		public DevSetEnemyBerserkBaseValueMessage()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DevSetEnemyBerserkBaseValueMessage(DevSetEnemyBerserkBaseValueMessage other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DevSetEnemyBerserkBaseValueMessage Clone()
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
		public bool Equals(DevSetEnemyBerserkBaseValueMessage other)
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

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DevSetEnemyBerserkBaseValueMessage other)
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

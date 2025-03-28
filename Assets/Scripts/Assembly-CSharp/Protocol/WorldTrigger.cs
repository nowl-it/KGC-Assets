using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorldTrigger : IMessage<WorldTrigger>, IMessage, IEquatable<WorldTrigger>, IDeepCloneable<WorldTrigger>, IBufferMessage
	{
		private static readonly MessageParser<WorldTrigger> _parser;

		private UnknownFieldSet _unknownFields;

		public const int CounterKeysFieldNumber = 1;

		private static readonly FieldCodec<string> _repeated_counterKeys_codec;

		private readonly RepeatedField<string> counterKeys_;

		public const int CounterValuesFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_counterValues_codec;

		private readonly RepeatedField<int> counterValues_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorldTrigger> Parser => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> CounterKeys => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CounterValues => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public WorldTrigger()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public WorldTrigger(WorldTrigger other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public WorldTrigger Clone()
		{
			return null;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTrigger other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
		public void MergeFrom(WorldTrigger other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

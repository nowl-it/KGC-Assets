using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ColosseumAbility : IMessage<ColosseumAbility>, IMessage, IEquatable<ColosseumAbility>, IDeepCloneable<ColosseumAbility>, IBufferMessage
	{
		private static readonly MessageParser<ColosseumAbility> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private int id_;

		public const int WorldTriggersFieldNumber = 2;

		private static readonly FieldCodec<WorldTrigger> _repeated_worldTriggers_codec;

		private readonly RepeatedField<WorldTrigger> worldTriggers_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ColosseumAbility> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Id
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
		public RepeatedField<WorldTrigger> WorldTriggers => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumAbility()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumAbility(ColosseumAbility other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumAbility Clone()
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
		public bool Equals(ColosseumAbility other)
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

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ColosseumAbility other)
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

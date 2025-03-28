using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RandomItemSave : IMessage<RandomItemSave>, IMessage, IEquatable<RandomItemSave>, IDeepCloneable<RandomItemSave>, IBufferMessage
	{
		private static readonly MessageParser<RandomItemSave> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ItemsFieldNumber = 1;

		private static readonly FieldCodec<Item> _repeated_items_codec;

		private readonly RepeatedField<Item> items_;

		public const int MaxRerollCountFieldNumber = 2;

		private int maxRerollCount_;

		public const int RemainRerollCountFieldNumber = 3;

		private int remainRerollCount_;

		public const int TierFieldNumber = 4;

		private int tier_;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<RandomItemSave> Parser => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Item> Items => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxRerollCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainRerollCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Tier
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
		public RandomItemSave()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomItemSave(RandomItemSave other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RandomItemSave Clone()
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
		public bool Equals(RandomItemSave other)
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
		public void MergeFrom(RandomItemSave other)
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

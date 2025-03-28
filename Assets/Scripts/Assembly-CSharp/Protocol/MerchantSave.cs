using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MerchantSave : IMessage<MerchantSave>, IMessage, IEquatable<MerchantSave>, IDeepCloneable<MerchantSave>, IBufferMessage
	{
		private static readonly MessageParser<MerchantSave> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ItemsFieldNumber = 1;

		private static readonly FieldCodec<Item> _repeated_items_codec;

		private readonly RepeatedField<Item> items_;

		public const int BoughtFieldNumber = 2;

		private ByteString bought_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MerchantSave> Parser => null;

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
		public ByteString Bought
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MerchantSave()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MerchantSave(MerchantSave other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MerchantSave Clone()
		{
			return null;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(MerchantSave other)
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

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MerchantSave other)
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

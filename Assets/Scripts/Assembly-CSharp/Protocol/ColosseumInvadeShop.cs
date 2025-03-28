using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ColosseumInvadeShop : IMessage<ColosseumInvadeShop>, IMessage, IEquatable<ColosseumInvadeShop>, IDeepCloneable<ColosseumInvadeShop>, IBufferMessage
	{
		private static readonly MessageParser<ColosseumInvadeShop> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ItemIdsFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_itemIds_codec;

		private readonly RepeatedField<int> itemIds_;

		public const int LockedFieldNumber = 2;

		private bool locked_;

		public const int BoughtFieldNumber = 3;

		private ByteString bought_;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ColosseumInvadeShop> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIds => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Locked
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
		public ColosseumInvadeShop()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumInvadeShop(ColosseumInvadeShop other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumInvadeShop Clone()
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
		public bool Equals(ColosseumInvadeShop other)
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
		public void MergeFrom(ColosseumInvadeShop other)
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

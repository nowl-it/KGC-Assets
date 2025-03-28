using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerSnapshotsMessage : IMessage<PlayerSnapshotsMessage>, IMessage, IEquatable<PlayerSnapshotsMessage>, IDeepCloneable<PlayerSnapshotsMessage>, IBufferMessage
	{
		private static readonly MessageParser<PlayerSnapshotsMessage> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdsFieldNumber = 1;

		private static readonly FieldCodec<string> _repeated_userIds_codec;

		private readonly RepeatedField<string> userIds_;

		public const int SnapshotsFieldNumber = 2;

		private static readonly FieldCodec<PlayerSnapshot> _repeated_snapshots_codec;

		private readonly RepeatedField<PlayerSnapshot> snapshots_;

		public const int PrivateSnapshotFieldNumber = 3;

		private PlayerPrivateSnapshot privateSnapshot_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSnapshotsMessage> Parser => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UserIds => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSnapshot> Snapshots => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPrivateSnapshot PrivateSnapshot
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
		public PlayerSnapshotsMessage()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSnapshotsMessage(PlayerSnapshotsMessage other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSnapshotsMessage Clone()
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
		public bool Equals(PlayerSnapshotsMessage other)
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

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return 0;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerSnapshotsMessage other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

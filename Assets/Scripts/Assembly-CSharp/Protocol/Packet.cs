using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Packet : IMessage<Packet>, IMessage, IEquatable<Packet>, IDeepCloneable<Packet>, IBufferMessage
	{
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Type
			{
				[OriginalName("None")]
				None = 0,
				[OriginalName("FieldDataMessage")]
				FieldDataMessage = 1,
				[OriginalName("RequestFieldDataMessage")]
				RequestFieldDataMessage = 2,
				[OriginalName("LobbyEnterMessage")]
				LobbyEnterMessage = 3,
				[OriginalName("LobbyReadyMessage")]
				LobbyReadyMessage = 4,
				[OriginalName("LobbyExitMessage")]
				LobbyExitMessage = 5,
				[OriginalName("LobbyAddBotMessage")]
				LobbyAddBotMessage = 6,
				[OriginalName("LobbyDataMessage")]
				LobbyDataMessage = 7,
				[OriginalName("CustomMatchGameStartMessage")]
				CustomMatchGameStartMessage = 8,
				[OriginalName("LobbyAlertMessage")]
				LobbyAlertMessage = 9,
				[OriginalName("PlayerSnapshotMessage")]
				PlayerSnapshotMessage = 10,
				[OriginalName("PlayerSnapshotsMessage")]
				PlayerSnapshotsMessage = 11,
				[OriginalName("ReenterSnapshotsMessage")]
				ReenterSnapshotsMessage = 12,
				[OriginalName("UnitLevelNotifyMessage")]
				UnitLevelNotifyMessage = 13,
				[OriginalName("AbilityLevelNotifyMessage")]
				AbilityLevelNotifyMessage = 14,
				[OriginalName("DevSetEnemyBerserkValueMessage")]
				DevSetEnemyBerserkValueMessage = 15,
				[OriginalName("DevSetEnemyBerserkBaseValueMessage")]
				DevSetEnemyBerserkBaseValueMessage = 16,
				[OriginalName("DevSetWinningStreakMessage")]
				DevSetWinningStreakMessage = 17
			}
		}

		private static readonly MessageParser<Packet> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		public const int TypeFieldNumber = 1;

		private Types.Type type_;

		public const int MessageFieldNumber = 2;

		private ByteString message_;

		public const int UserIdFieldNumber = 3;

		private static readonly string UserIdDefaultValue;

		private string userId_;

		public const int IdFieldNumber = 4;

		private static readonly int IdDefaultValue;

		private int id_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Packet> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Types.Type Type
		{
			get
			{
				return default(Types.Type);
			}
			set
			{
			}
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ByteString Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string UserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUserId => false;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
		public bool HasId => false;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Packet()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Packet(Packet other)
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Packet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUserId()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearId()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return false;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(Packet other)
		{
			return false;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
		public void MergeFrom(Packet other)
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

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyPlayerData : IMessage<LobbyPlayerData>, IMessage, IEquatable<LobbyPlayerData>, IDeepCloneable<LobbyPlayerData>, IBufferMessage
	{
		private static readonly MessageParser<LobbyPlayerData> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdFieldNumber = 1;

		private int userId_;

		public const int SlotIdxFieldNumber = 2;

		private int slotIdx_;

		public const int IsHostFieldNumber = 3;

		private bool isHost_;

		public const int IsBotFieldNumber = 4;

		private bool isBot_;

		public const int BotTierFieldNumber = 5;

		private int botTier_;

		public const int IsReadyFieldNumber = 6;

		private bool isReady_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyPlayerData> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UserId
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
		public int SlotIdx
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
		public bool IsHost
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
		public bool IsBot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BotTier
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
		public bool IsReady
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
		public LobbyPlayerData()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LobbyPlayerData(LobbyPlayerData other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyPlayerData Clone()
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
		public bool Equals(LobbyPlayerData other)
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
		public void MergeFrom(LobbyPlayerData other)
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

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReenterSnapShots : IMessage<ReenterSnapShots>, IMessage, IEquatable<ReenterSnapShots>, IDeepCloneable<ReenterSnapShots>, IBufferMessage
	{
		private static readonly MessageParser<ReenterSnapShots> _parser;

		private UnknownFieldSet _unknownFields;

		public const int RoundFieldNumber = 1;

		private int round_;

		public const int UserIdsFieldNumber = 2;

		private static readonly FieldCodec<string> _repeated_userIds_codec;

		private readonly RepeatedField<string> userIds_;

		public const int SnapshotsFieldNumber = 3;

		private static readonly FieldCodec<PlayerSnapshot> _repeated_snapshots_codec;

		private readonly RepeatedField<PlayerSnapshot> snapshots_;

		public const int WinStreaksFieldNumber = 4;

		private static readonly FieldCodec<int> _repeated_winStreaks_codec;

		private readonly RepeatedField<int> winStreaks_;

		public const int EnemyBerserkValuesFieldNumber = 5;

		private static readonly FieldCodec<int> _repeated_enemyBerserkValues_codec;

		private readonly RepeatedField<int> enemyBerserkValues_;

		public const int LifesFieldNumber = 6;

		private static readonly FieldCodec<int> _repeated_lifes_codec;

		private readonly RepeatedField<int> lifes_;

		public const int PrivateSnapshotFieldNumber = 7;

		private PlayerPrivateSnapshot privateSnapshot_;

		public const int OpponentsFieldNumber = 8;

		private static readonly FieldCodec<string> _repeated_opponents_codec;

		private readonly RepeatedField<string> opponents_;

		public const int ReportedPlayersFieldNumber = 9;

		private static readonly FieldCodec<string> _repeated_reportedPlayers_codec;

		private readonly RepeatedField<string> reportedPlayers_;

		public const int DiedPlayerUsedIdsFieldNumber = 10;

		private static readonly FieldCodec<string> _repeated_diedPlayerUsedIds_codec;

		private readonly RepeatedField<string> diedPlayerUsedIds_;

		public const int DiedPlayerRanksFieldNumber = 11;

		private static readonly FieldCodec<int> _repeated_diedPlayerRanks_codec;

		private readonly RepeatedField<int> diedPlayerRanks_;

		public const int CurrentMinRankFieldNumber = 12;

		private int currentMinRank_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReenterSnapShots> Parser => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Round
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
		public RepeatedField<string> UserIds => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSnapshot> Snapshots => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> WinStreaks => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnemyBerserkValues => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Lifes => null;

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
		public RepeatedField<string> Opponents => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> ReportedPlayers => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> DiedPlayerUsedIds => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> DiedPlayerRanks => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CurrentMinRank
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
		public ReenterSnapShots()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReenterSnapShots(ReenterSnapShots other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReenterSnapShots Clone()
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
		public bool Equals(ReenterSnapShots other)
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

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return 0;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(ReenterSnapShots other)
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

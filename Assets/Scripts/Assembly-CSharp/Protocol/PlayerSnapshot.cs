using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerSnapshot : IMessage<PlayerSnapshot>, IMessage, IEquatable<PlayerSnapshot>, IDeepCloneable<PlayerSnapshot>, IBufferMessage
	{
		private static readonly MessageParser<PlayerSnapshot> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UnitsFieldNumber = 1;

		private static readonly FieldCodec<FieldUnit> _repeated_units_codec;

		private readonly RepeatedField<FieldUnit> units_;

		public const int AiSaveDatasFieldNumber = 2;

		private static readonly FieldCodec<string> _repeated_aiSaveDatas_codec;

		private readonly RepeatedField<string> aiSaveDatas_;

		public const int GoldFieldNumber = 3;

		private int gold_;

		public const int SlotFieldNumber = 4;

		private int slot_;

		public const int SlotBonusFieldNumber = 5;

		private int slotBonus_;

		public const int AbilityLevelFieldNumber = 6;

		private int abilityLevel_;

		public const int AbilityExpFieldNumber = 7;

		private int abilityExp_;

		public const int AbilitiesFieldNumber = 8;

		private static readonly FieldCodec<ColosseumAbility> _repeated_abilities_codec;

		private readonly RepeatedField<ColosseumAbility> abilities_;

		public const int CustomStackKeysFieldNumber = 9;

		private static readonly FieldCodec<string> _repeated_customStackKeys_codec;

		private readonly RepeatedField<string> customStackKeys_;

		public const int CustomStackValuesFieldNumber = 10;

		private static readonly FieldCodec<int> _repeated_customStackValues_codec;

		private readonly RepeatedField<int> customStackValues_;

		public const int OpponentFieldNumber = 11;

		private string opponent_;

		public const int UsedInvadeItemsFieldNumber = 12;

		private static readonly FieldCodec<int> _repeated_usedInvadeItems_codec;

		private readonly RepeatedField<int> usedInvadeItems_;

		public const int InvadeSuccessCountFieldNumber = 13;

		private int invadeSuccessCount_;

		public const int LastStageClearedFieldNumber = 14;

		private bool lastStageCleared_;

		public const int WaitingUnitsFieldNumber = 15;

		private static readonly FieldCodec<FieldUnit> _repeated_waitingUnits_codec;

		private readonly RepeatedField<FieldUnit> waitingUnits_;

		public const int ItemsFieldNumber = 16;

		private static readonly FieldCodec<Item> _repeated_items_codec;

		private readonly RepeatedField<Item> items_;

		public const int ItemPositionsFieldNumber = 17;

		private static readonly FieldCodec<int> _repeated_itemPositions_codec;

		private readonly RepeatedField<int> itemPositions_;

		public const int ItemQueueFieldNumber = 18;

		private static readonly FieldCodec<Item> _repeated_itemQueue_codec;

		private readonly RepeatedField<Item> itemQueue_;

		public const int SpawnLevelUpCountFieldNumber = 19;

		private int spawnLevelUpCount_;

		public const int InvadePointFieldNumber = 20;

		private int invadePoint_;

		public const int InvadeItemsFieldNumber = 21;

		private static readonly FieldCodec<int> _repeated_invadeItems_codec;

		private readonly RepeatedField<int> invadeItems_;

		public const int AdditionalInvadeItemCostFieldNumber = 22;

		private int additionalInvadeItemCost_;

		public const int InvadeShopRerollCountFieldNumber = 23;

		private int invadeShopRerollCount_;

		public const int QueuedRewardPanelsFieldNumber = 24;

		private static readonly FieldCodec<QueuedRewardPanel> _repeated_queuedRewardPanels_codec;

		private readonly RepeatedField<QueuedRewardPanel> queuedRewardPanels_;

		public const int ChoiceTarotListFieldNumber = 25;

		private static readonly FieldCodec<int> _repeated_choiceTarotList_codec;

		private readonly RepeatedField<int> choiceTarotList_;

		public const int RandomTarotListFieldNumber = 26;

		private static readonly FieldCodec<int> _repeated_randomTarotList_codec;

		private readonly RepeatedField<int> randomTarotList_;

		public const int TarotsFieldNumber = 27;

		private static readonly FieldCodec<ColosseumTarot> _repeated_tarots_codec;

		private readonly RepeatedField<ColosseumTarot> tarots_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSnapshot> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FieldUnit> Units => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> AiSaveDatas => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Gold
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
		public int Slot
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
		public int SlotBonus
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
		public int AbilityLevel
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
		public int AbilityExp
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
		public RepeatedField<ColosseumAbility> Abilities => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> CustomStackKeys => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CustomStackValues => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Opponent
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
		public RepeatedField<int> UsedInvadeItems => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InvadeSuccessCount
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
		public bool LastStageCleared
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
		public RepeatedField<FieldUnit> WaitingUnits => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Item> Items => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemPositions => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Item> ItemQueue => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnLevelUpCount
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
		public int InvadePoint
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
		public RepeatedField<int> InvadeItems => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AdditionalInvadeItemCost
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
		public int InvadeShopRerollCount
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
		public RepeatedField<QueuedRewardPanel> QueuedRewardPanels => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChoiceTarotList => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RandomTarotList => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ColosseumTarot> Tarots => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSnapshot()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSnapshot(PlayerSnapshot other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSnapshot Clone()
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
		public bool Equals(PlayerSnapshot other)
		{
			return false;
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
		public void MergeFrom(PlayerSnapshot other)
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

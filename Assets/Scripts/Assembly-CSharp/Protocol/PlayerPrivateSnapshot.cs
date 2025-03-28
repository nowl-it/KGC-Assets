using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Protocol
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerPrivateSnapshot : IMessage<PlayerPrivateSnapshot>, IMessage, IEquatable<PlayerPrivateSnapshot>, IDeepCloneable<PlayerPrivateSnapshot>, IBufferMessage
	{
		private static readonly MessageParser<PlayerPrivateSnapshot> _parser;

		private UnknownFieldSet _unknownFields;

		public const int InvadeShopFieldNumber = 1;

		private ColosseumInvadeShop invadeShop_;

		public const int SelectAbilityPanelPickedAbilitiesFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_selectAbilityPanelPickedAbilities_codec;

		private readonly RepeatedField<int> selectAbilityPanelPickedAbilities_;

		public const int MerchantFieldNumber = 3;

		private MerchantSave merchant_;

		public const int RandomItemFieldNumber = 4;

		private RandomItemSave randomItem_;

		public const int LastConnectedRoundFieldNumber = 5;

		private int lastConnectedRound_;

		public const int AbilityRerollCountFieldNumber = 6;

		private int abilityRerollCount_;

		public const int AbandonedAbilityListFieldNumber = 7;

		private static readonly FieldCodec<int> _repeated_abandonedAbilityList_codec;

		private readonly RepeatedField<int> abandonedAbilityList_;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerPrivateSnapshot> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumInvadeShop InvadeShop
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
		public RepeatedField<int> SelectAbilityPanelPickedAbilities => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MerchantSave Merchant
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
		public RandomItemSave RandomItem
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
		public int LastConnectedRound
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
		public int AbilityRerollCount
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
		public RepeatedField<int> AbandonedAbilityList => null;

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerPrivateSnapshot()
		{
		}

		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerPrivateSnapshot(PlayerPrivateSnapshot other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPrivateSnapshot Clone()
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
		public bool Equals(PlayerPrivateSnapshot other)
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

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPrivateSnapshot other)
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

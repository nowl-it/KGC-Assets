using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AwesomeData.Encrypted;
using Awesomepiece;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Firebase;
using Firebase.Messaging;
using Protocol;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager
{
	public class BabelState
	{
		public bool autoStarted;

		public int maxStageAtEnter;

		public int currentStage;

		public int babelId;
	}

	public class BabelBarrack
	{
		public int[] cards;

		public int[] buildings;

		public List<ArtifactModel> artifacts;

		public int[] potentials;
	}

	public class ClanRaidBarrack
	{
		public ClanRaidCardInfo[] cards;

		public int[] buildings;

		public List<ArtifactModel> artifacts;

		public int[] potentials;
	}

	public enum CallbackType
	{
		Gold = 0,
		Cash = 1,
		Exp = 2,
		LevelUp = 3,
		AddCard = 4,
		DeckChange = 5,
		CardExp = 6,
		CardLevelUp = 7,
		BuildingLevelUp = 8,
		Heart = 9,
		Gacha = 10,
		ProfileIcon = 11,
		Artifact = 12,
		UnitExpItem = 13,
		Potential = 14,
		PotentialTierUp = 15,
		EtcPlayCounts = 16,
		Treasure = 17,
		Accessory = 18,
		Babel = 19,
		ClanRaid = 20
	}

	public class TerritoryUnitLaborCoolTime
	{
		public int unitId;

		public DateTime nextAt;
	}

	public class TerritoryUnitSkinTokenCoolTime
	{
		public int unitId;

		public DateTime nextAt;
	}

	public struct ProfileUIInfo
	{
		public PlayerProfile playerProfile;

		public string castleName;

		public string kingName;

		public int accountId;

		public int iconId;

		public int nameTagId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass255_0
	{
		public bool processed;

		internal void _003CCardLevelUp_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass256_0
	{
		public bool processed;

		internal void _003CCardPotentialTierUp_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass258_0
	{
		public bool processed;

		internal void _003CUseCardExpItem_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass259_0
	{
		public bool processed;

		internal void _003CUseCardSoulToExp_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass260_0
	{
		public bool processed;

		internal void _003CUseCardSoulItemToExp_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass261_0
	{
		public bool processed;

		internal void _003CUseCardSoulItem_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass554_0
	{
		public GameManager _003C_003E4__this;

		public bool processed;

		internal void _003CLoadScene_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass602_0
	{
		public GameManager _003C_003E4__this;

		public Action OnCompleted;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAddInventoryCount_003Ed__625 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<PlayerInventoryCountResponseModel> _003C_003Et__builder;

		public string inventoryType;

		public int count;

		private UniTask<PlayerInventoryCountResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAfterMatchComplete_003Ed__592 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public string endPoint;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAfterUpgradeCard_003Ed__257 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CardWithCandiesResponseModel ret;

		public GameManager _003C_003E4__this;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCanEquipTreasureCheck_003Ed__620 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<MultiPriceButtonPopup.Response> _003C_003Et__builder;

		public int unitID;

		public TreasureModel treasure;

		public bool showAlert;

		public GameManager _003C_003E4__this;

		public ConditionalBase cond;

		private int _003CneedGold_003E5__2;

		private UniTask<MultiPriceButtonPopup.Response>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCancelMatchmaking_003Ed__595 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCardLevelUp_003Ed__255 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public int id;

		public List<int> candies;

		private _003C_003Ec__DisplayClass255_0 _003C_003E8__1;

		public GameManager _003C_003E4__this;

		private CardWithCandiesResponseModel _003Cret_003E5__2;

		private UniTask<CardWithCandiesResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCardPotentialTierUp_003Ed__256 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int id;

		public List<int> candies;

		private _003C_003Ec__DisplayClass256_0 _003C_003E8__1;

		public GameManager _003C_003E4__this;

		private UniTask<CardWithCandiesResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckMission_003Ed__330 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public List<string> condTypes;

		public GameManager _003C_003E4__this;

		public Action callback;

		private UniTask<MissionResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckRogueLikeMission_003Ed__569 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<RogueLikeMissionResponseModel>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckStartGameValidate_003Ed__634 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public GameStartRequestModel.DeckInfo deckInfo;

		public bool checkArtifact;

		public GameManager _003C_003E4__this;

		public bool checkBuilding;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckTreasureWishListValid_003Ed__639 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckXcd_003Ed__419 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private string _003Ccookie_003E5__2;

		private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDeleteRogueLikeSaveDataWithoutLogging_003Ed__562 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<DeleteRogueLikeDataResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDismantleAccessoriesImpl_003Ed__627 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<(Dictionary<int, int>, AccessoryResultResponseModel)> _003C_003Et__builder;

		public HashSet<int> accessoryDismantleInfo;

		public GameManager _003C_003E4__this;

		public Func<int, Dictionary<int, int>, bool, UniTask<bool>> alertTaskFunc;

		private List<int> _003Caccessories_003E5__2;

		private Dictionary<int, int> _003CrewardItems_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDispatchMatchmakingWebSocketEvent_003Ed__600 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BaseMessage message;

		public GameManager _003C_003E4__this;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDispatchReenterWebSocketEvent_003Ed__599 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BaseMessage message;

		public GameManager _003C_003E4__this;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CEquipTreasure_003Ed__618 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public int treasureID;

		public int unitID;

		private UniTask<MultiPriceButtonPopup.Response>.Awaiter _003C_003Eu__1;

		private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchAssignment_003Ed__589 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchClanRaidSupporters_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<ClanRaidSupportResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchOtherClan_003Ed__527 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

		public int clanId;

		public GameManager _003C_003E4__this;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchPlayerTutorialStatus_003Ed__292 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<KeyValuesResponseModel> _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<KeyValuesResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchTreasureWishList_003Ed__640 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public Action onFetchCompleted;

		private UniTask<TreasureWishListResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGameSkipCheckAndShortcut_003Ed__637 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private string _003Cshortcut_003E5__2;

		private Popup.Type _003Ctype_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetMissionReward_003Ed__335 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<MissionRewardResponseModel> _003C_003Et__builder;

		public int missionId;

		public GameManager _003C_003E4__this;

		public bool reloadAfterSuccess;

		private UniTask<MissionRewardResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandleMissionReward_003Ed__462 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MissionRewardResponseModel model;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CInstantiateAudioController_003Ed__602 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public Action OnCompleted;

		public bool async;

		private _003C_003Ec__DisplayClass602_0 _003C_003E8__1;

		private AddressableAsyncExtensions.AsyncOperationHandleAwaiter<GameObject> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLoadMissions_003Ed__328 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public Action callback;

		private UniTask<MissionResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLoadRogueLikeFromServer_003Ed__561 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private bool _003CloadedFromClient_003E5__2;

		private UniTask<RogueLikeGameDataResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<DeleteRogueLikeDataResponseModel>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLoadScene_003Ed__554 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public string scene;

		private _003C_003Ec__DisplayClass554_0 _003C_003E8__1;

		public LoadSceneMode loadSceneMode;

		private UniTaskVoid.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnFirebaseTokenReceived_003Ed__219 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TokenReceivedEventArgs token;

		public GameManager _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSaveRogueLikeToServer_003Ed__560 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public bool restoreFromLastSave;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetAccessoryState_003Ed__623 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

		public AccessoryModel accessory;

		public int state;

		public GameManager _003C_003E4__this;

		private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetClanRaidDeckName_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public string name;

		public int idx;

		public InputField revertTo;

		private UniTask<ClanRaidDeckInfoResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetEarlyAccessMode_003Ed__230 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetPotential_003Ed__300 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

		public bool setToAll;

		public int unitId;

		public GameManager _003C_003E4__this;

		public int potentialSlot;

		public bool ignorePreset;

		private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetTreasureState_003Ed__621 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

		public TreasureModel treasure;

		public int state;

		public GameManager _003C_003E4__this;

		private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CStartColosseumMatchmaking_003Ed__588 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private bool _003CisMatchDone_003E5__2;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTestStartColosseumMatchMaking_003Ed__590 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		public bool isSingle;

		public int botNum;

		private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CUpdateRogueLikeMission_003Ed__327 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask<RogueLikeMissionDataResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CUseCardExpItem_003Ed__258 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int id;

		public int count;

		private _003C_003Ec__DisplayClass258_0 _003C_003E8__1;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CUseCardSoulItem_003Ed__261 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int id;

		public int count;

		private _003C_003Ec__DisplayClass261_0 _003C_003E8__1;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CUseCardSoulItemToExp_003Ed__260 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int id;

		public int count;

		private _003C_003Ec__DisplayClass260_0 _003C_003E8__1;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CUseCardSoulToExp_003Ed__259 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int id;

		public int count;

		private _003C_003Ec__DisplayClass259_0 _003C_003E8__1;

		public GameManager _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CWaitForCompleteAndCheckRogueLikeMission_003Ed__568 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public GameManager _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public BabelState babelState;

	public BabelBarrack babelBarrack;

	public BabelResponseModel babelModel;

	public ClanRaidModel devTestClanRaid;

	private ClanRaidModel _clanRaid;

	public List<ClanRaidDeckInfo> devTestClanRaidDeckInfos;

	public List<ClanRaidSupportModel> clanRaidSupporters;

	public ClanRaidBarrack clanRaidBarrack;

	public DateTime clanRaidUntilAt;

	public DateTime clanRaidStartAt;

	public ObscuredBool clanRaidEnabled;

	public DateTime clanRaidLockedByLeaveUntilAt;

	public DateTime canPlayClanRaidAt;

	public ObscuredInt clanRaidDeckIdx;

	public ObscuredBool isRetryingClanRaid;

	public ObscuredBool isClanRaidPractice;

	public ObscuredInt practiceClanRaidBoss;

	public ObscuredBool isDevTestClanRaid;

	public ObscuredInt devTestClanRaidDivinePower;

	public ObscuredInt devTestClanRaidBoss;

	public bool showClanRaidRetryAlert;

	private static readonly GameManager _singleton;

	public bool offlineMode;

	public string patchFolder;

	public PlayerData data;

	public DateTime lastHeartTime;

	public ShopResponseModel currentShop;

	public TreasureWishListResponseModel treasureWishListModel;

	public Settings settings;

	public GameObject audioController;

	public bool handleFlagInventoryCompleted;

	public bool handleNameTagInventoryCompleted;

	public bool handlePlayerTerritoryCompleted;

	public bool handleRogueLikeDLCCompleted;

	public bool loginStreamingPreviewShown;

	public int currentTheme;

	public Scene_Base currentScene;

	public Action afterSceneLoaded;

	public int lastConsumedHeart;

	public int[] eliteLevels;

	public int[] eliteLevelRatio;

	public int difficulty;

	public Dictionary<int, MissionData> missions;

	public Dictionary<int, MissionData> rogueLikeMissions;

	public List<MissionStatisticsData> rogueLikeMissionStatistics;

	public int totalRogueLikeUser;

	public MissionResponseModel missionModel;

	public PostResponseModel postModel;

	private List<InvasionRewardDatasResponseModel.RewardData> _invasionRewardDatas;

	public bool logined;

	private List<(CallbackType type, Action callback)> _callbacks;

	private bool _inited;

	public TimeSpan serverTimeGap;

	public TimeSpan serverTimeZoneDifference;

	public string currentGameId;

	public bool fetchNonCachedRanking;

	public bool tutorialSkipped;

	public bool loadSavedGame;

	public List<BatchData> rankingStageUnits;

	public string patchsetVersion;

	public bool usePatch;

	public bool showAskPatchPopup;

	public List<int> openEventModes;

	public Dictionary<int, int> eventModesFlagCost;

	public float lastPostReceiveTime;

	public int lastPostReceiveId;

	public int pvpId;

	public PvPDeckInfo pvpMyDeck;

	public PvPDeckInfo pvpEnemyDeck;

	public PvPInfoResponseModel pvpData;

	public bool isArenaTraining;

	public List<(string msg, Action<bool> action)> popupQueue;

	public bool canUseFirebase;

	public FirebaseApp firebaseApp;

	public string firebaseToken;

	public int foodBoosterLevel;

	public ArtifactInventoryResponseModel artifactInventory;

	public List<ArtifactModel> equippedArtifacts;

	public TreasureInventoryResponseModel treasureInventory;

	public HashSet<int> newAddedTreasures_Seen;

	public AccessoryInventoryResponseModel accessoryInventory;

	public AccessoryInventoryResponseModel earlyAccessModeAccessoryInventory;

	public HashSet<int> newAddedAccessories_Seen;

	public int lastPassPoint;

	public SeasonPassResponseModel passModel;

	public SeasonPassEventBoosterResponseModel passEventBoosterModel;

	public FourthYearEventResponseModel fourthYearEventModel;

	public int clanRole;

	public DateTime clanRequestSupportCooltime;

	public LocalPushManager localPushManager;

	public int rogueLikeSelectedFirstHero;

	public int rogueLikeSelectedFirstHeroPotentialSlot;

	private List<RogueLikeCardData> _rogueLikeCards;

	private List<RogueLikeArtifactModel> _rogueLikeArtifacts;

	private List<ArtifactModel> _cachedCastedRogueLikeArtifacts;

	private int[] _rogueLikeBuildings;

	public List<int> rogueLikeAvailableBuildingIdx;

	private int _rogueLikeUpgradedBuildingIndex;

	private bool _rogueLikeDidSelectedBuildingArtifact;

	public List<int> rogueLikeBannedHeroes;

	public List<int> rogueLikeSelectableBuildingArtifacts;

	public List<int> rogueLikeUsedBuildingArtifacts;

	public int rogueLikeFinalBossId;

	public int rogueLikeLastHeartPaidFloor;

	private RogueLikeOutGameDataResponseModel _rogueLikeOutGameData;

	public RogueLikeInGameStatus rogueLikeInGameStatus;

	public Queue<int> rogueLikeClearedMissions;

	public readonly Dictionary<int, TerritoryBuildingData> unitToAssignedBuildingDict;

	private EncryptedFloat[] _territoryStatBuffPers;

	private readonly List<TerritoryUnitLaborCoolTime> _territoryUnitsLaborCoolTimes;

	private readonly List<TerritoryUnitSkinTokenCoolTime> _territoryUnitsSkinTokenCoolTimes;

	public string lastServerName;

	public Dictionary<int, int> defaultPotential;

	public DailyAttendanceEventsResponseModel dailyAttendanceEventsData;

	public FlagInventoryResponseModel flagInventoryModel;

	public NameTagInventoryResponseModel nameTagInventoryModel;

	public Scene_Game.RogueLikeSaveData rogueLikeSaveData;

	public int rogueLikeSaveDataVersion;

	private bool _rogueLikeMissionCheckPending;

	private bool _rogueLikeMissionCheckComplete;

	public Dictionary<int, CustomPickupsResponseModel> customPickupModels;

	public List<int> boughtRogueLikeDLCs;

	public List<int> boughtRogueLikeBuildings;

	public PlayersMetaDataMessage playersMetaDataMessage;

	public bool colosseumCustomMatchMinimized;

	private bool _isInMatchmaking;

	private bool _matchLock;

	public bool isCancelClicked;

	private int _currentMatchmakingTheme;

	public DateTime matchmakingStartedAt;

	public string currentColosseumGameId;

	public List<ColosseumPlayerDataResponseModel.ColosseumPlayerData> colosseumPlayerDataList;

	public List<LobbyPlayerData> colosseumCustomMatchDataList;

	public bool isCustomColosseumMatch;

	public PlayerColosseumInfoResponseModel colosseumData;

	public int colosseumReenteredStage;

	public string handleMaxInventory;

	public bool treasureAlertProcessed;

	public bool accessoryAlertProcessed;

	public bool isEarlyAccessMode;

	public ResourceEarlyAccessModeInfo resEarlyAccessModeInfo;

	private DateTime _summonTutorialEndAt;

	public static ulong LaborTimerHash;

	public static ulong HeartTimerHash;

	public static ulong SeasonalEventTokenTimerHash;

	private DateTime _lastFetchSupporterTime;

	private string _lastUserID;

	private List<ArtifactModel> _nullList;

	private List<ArtifactModel> _enemtyNullList;

	private float _lastTreasureEquipTime;

	public ClanRaidModel clanRaid
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public List<ClanRaidDeckInfo> clanRaidDeckInfos
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool canRogueLikeChallenge => false;

	public int rogueLikeChallengeLevel { get; set; }

	public List<InvasionRewardDatasResponseModel.RewardData> invasionRewardDatas => null;

	public bool isPvpEnemyDeckIsPreset => false;

	public ClanModel clan { get; private set; }

	public RogueLikeOutGameDataResponseModel rogueLikeOutGameData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RogueLikeOutGameStatus rogueLikeOutGameStatus { get; private set; }

	public int rogueLikeTotalClearCount { get; private set; }

	public PlayerTerritoryModel playerTerritoryModel { get; private set; }

	public Dictionary<int, int> inventory { get; private set; }

	public PlayerTerritoryTycoonModel playerTerritoryTycoonModel { get; private set; }

	public DateTime? summonTutorialEndAt
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<TerritoryBuildingData> currentTerritoryBuildingDatas => null;

	public void HandlePlayerBabel(BabelResponseModel model)
	{
	}

	public ResourceShopItem GetBabelPassItem(int babelId, int stage)
	{
		return null;
	}

	public bool CheckBoughtBabelPass(int babelId, int stage)
	{
		return false;
	}

	public BabelResponseModel.BabelModel GetBabelData(int babelId)
	{
		return null;
	}

	public void HandleClanRaid(ClanRaidModel model)
	{
	}

	[AsyncStateMachine(typeof(_003CSetClanRaidDeckName_003Ed__35))]
	public UniTaskVoid SetClanRaidDeckName(int idx, string name, InputField revertTo)
	{
		return default(UniTaskVoid);
	}

	public void HandleClanRaidDeckInfo(ClanRaidDeckInfoResponseModel model)
	{
	}

	public List<ClanRaidDeckInfo> GetClanRaidUsedSlot()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CFetchClanRaidSupporters_003Ed__38))]
	public void FetchClanRaidSupporters()
	{
	}

	public bool CheckClanRaidEnabled()
	{
		return false;
	}

	public float GetClanRaidBossHybridDef()
	{
		return 0f;
	}

	public int GetClanRaidBossHp(int unitID = -1)
	{
		return 0;
	}

	public string GetPrettyClanRaidDeckName(ClanRaidDeckInfo deckInfo)
	{
		return null;
	}

	public string GetDefaultClanRaidDeckName(int index, GameCompleteRequestModel.RoundData roundData, ClanRaidCardInfo[] cards = null)
	{
		return null;
	}

	public (GameCompleteRequestModel.EndFieldUnit, ClanRaidCardInfo, int) FindClanRaidThumbnailUnit(ClanRaidDeckData deckData)
	{
		return default((GameCompleteRequestModel.EndFieldUnit, ClanRaidCardInfo, int));
	}

	public bool HasClanRaidDeck()
	{
		return false;
	}

	public int GetDivinePowerLevel(long damageAmount)
	{
		return 0;
	}

	public float GetDetailedDivinePowerLevel(long damageAmount)
	{
		return 0f;
	}

	public int GetDivinePowerDamageAmount(float level)
	{
		return 0;
	}

	public string GetClanRaidRemainTime()
	{
		return null;
	}

	public static GameManager Get()
	{
		return null;
	}

	public void Init()
	{
	}

	public void CheckFirebase()
	{
	}

	[AsyncStateMachine(typeof(_003COnFirebaseTokenReceived_003Ed__219))]
	public void OnFirebaseTokenReceived(object sender, TokenReceivedEventArgs token)
	{
	}

	public void OnFirebaseMessageReceived(object sender, MessageReceivedEventArgs e)
	{
	}

	public void LoadSetting()
	{
	}

	public void SaveSetting()
	{
	}

	public void Subscribe(CallbackType type, Action callback)
	{
	}

	public void Unsubscribe(CallbackType type, Action callback)
	{
	}

	public void ShootCallback(CallbackType type)
	{
	}

	public void ClearCallbacks()
	{
	}

	[AsyncStateMachine(typeof(_003CSetEarlyAccessMode_003Ed__230))]
	public void SetEarlyAccessMode()
	{
	}

	public bool IsEarlyAccessModeUnit(int unitId)
	{
		return false;
	}

	public void AddGold(int gold, bool isFree, int before, bool log = true)
	{
	}

	public void ConsumeGold(int gold, string productId, string goldSpentTo, int before, bool log = true)
	{
	}

	public bool HasGold(long gold)
	{
		return false;
	}

	public bool CheckShowGoldPopup(long gold, Action buyCallBack, bool forceShow = false)
	{
		return false;
	}

	public void AddCash(int cash, bool isFree, int before, bool log = true)
	{
	}

	public void ConsumeCash(int cash, string productId, string cashSpentTo, int before, bool log = true)
	{
	}

	public bool HasCash(long cash)
	{
		return false;
	}

	public bool CheckShowCashPopup(long cash, Action buyCallBack, bool forceShow = false, bool blur = false)
	{
		return false;
	}

	public void AddCard(CardData card)
	{
	}

	public bool HasCard(int id)
	{
		return false;
	}

	public bool IsAllCardMaxLevel()
	{
		return false;
	}

	public CardData GetCard(int id)
	{
		return null;
	}

	public List<CardInfo> GetCardInfos(IEnumerable<int> ids)
	{
		return null;
	}

	public bool CanAddNewCard()
	{
		return false;
	}

	public bool CanCardMaxLv(CardData target)
	{
		return false;
	}

	public bool CanCardMaxLv(CardData target, int exp)
	{
		return false;
	}

	public void SetCardExp(int id, int exp)
	{
	}

	public void AddCardExp(int id, int exp)
	{
	}

	public void SetCardSoul(int id, int soul)
	{
	}

	public void AddCardSoul(int id, int soul)
	{
	}

	public bool CanCardLevelUp(int id, int type = 0)
	{
		return false;
	}

	public bool CanCardLevelUpExpOnly(int id)
	{
		return false;
	}

	public bool CanCardLevelUpSoulOnly(int id)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CCardLevelUp_003Ed__255))]
	public UniTask CardLevelUp(int id, List<int> candies)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CCardPotentialTierUp_003Ed__256))]
	public Task CardPotentialTierUp(int id, List<int> candies)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CAfterUpgradeCard_003Ed__257))]
	private UniTask AfterUpgradeCard(CardWithCandiesResponseModel ret)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CUseCardExpItem_003Ed__258))]
	public Task UseCardExpItem(int id, int count)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUseCardSoulToExp_003Ed__259))]
	public Task UseCardSoulToExp(int id, int count)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUseCardSoulItemToExp_003Ed__260))]
	public Task UseCardSoulItemToExp(int id, int count)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUseCardSoulItem_003Ed__261))]
	public Task UseCardSoulItem(int id, int count)
	{
		return null;
	}

	public void CardLevelDevSet(int id, int level)
	{
	}

	public void CardSkinDevSet(int id, int skin)
	{
	}

	public void CardPotentialTierDevSet(int id, int tier)
	{
	}

	public bool EquipCard(int idx, int id)
	{
		return false;
	}

	public bool UnequipCard(int id)
	{
		return false;
	}

	public List<ResourceSynergy> GetSynergies()
	{
		return null;
	}

	public int GetSynergyEffect(string key, int @default = 0)
	{
		return 0;
	}

	public int[] GetRogueLikeBuildings()
	{
		return null;
	}

	public List<BuildingData> GetPlayerBuildings(bool withArtifact = true)
	{
		return null;
	}

	public int[] GetBuildingLevels(BattleManager battle, bool adjustArtifact = false)
	{
		return null;
	}

	public int GetPlayerBuildingLevel(int id, bool limit = true)
	{
		return 0;
	}

	public BuildingData GetBuilding(int id, BattleManager battle)
	{
		return null;
	}

	public bool CanBuildingLevelUp(int id)
	{
		return false;
	}

	public void BuildingLevelUp(int id)
	{
	}

	public void BuildingLevelDevSet(int id, int level)
	{
	}

	public ResourceBuilding.EffectValue GetPlayerBuildingEffectValue(string key)
	{
		return null;
	}

	public int GetPlayerBuildingEffect(string key, int @default = 0)
	{
		return 0;
	}

	public float GetPlayerBuildingEffectFloat(string key, float @default = 0f)
	{
		return 0f;
	}

	public int GetPlayerBuildingLevelSum()
	{
		return 0;
	}

	public int GetBuildingMaxLevel(int id)
	{
		return 0;
	}

	public void AddExp(int value)
	{
	}

	public void AddHeart(int value)
	{
	}

	public void ConsumeHeart(int value, string mode)
	{
	}

	public bool HasHeart(int value)
	{
		return false;
	}

	public int GetFlagBoosterCost(int theme, int level)
	{
		return 0;
	}

	public bool HasFlag(int value)
	{
		return false;
	}

	public void SetFlag(int value, bool showDiffEffect = true)
	{
	}

	public int GetMaxHeart()
	{
		return 0;
	}

	public bool IsMaxHeart()
	{
		return false;
	}

	public void HandlePlayerDataResponse(PlayerDataResponseModel model, bool handlePlayerCurrencies = true)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchPlayerTutorialStatus_003Ed__292))]
	public UniTask<KeyValuesResponseModel> FetchPlayerTutorialStatus()
	{
		return default(UniTask<KeyValuesResponseModel>);
	}

	public void HandlePlayerTutorialStatus(KeyValuesResponseModel ret)
	{
	}

	public void HandlePlayerCurrencies(PlayerCurrenciesResponseModel ret)
	{
	}

	public void HandlePlayerDailyConsumedCurrencies(PlayerCurrenciesResponseModel ret)
	{
	}

	public EventMissionData GetEvent(ResourceMission.EventType eventType)
	{
		return null;
	}

	public void HandleCardListResponse(CardListResponseModel model)
	{
	}

	public void HandleCardListResponse(List<CardResponseModel> cards)
	{
	}

	public void UpdateOrAddCards(List<CardResponseModel> cards)
	{
	}

	[AsyncStateMachine(typeof(_003CSetPotential_003Ed__300))]
	public UniTask<DeckResponseModel> SetPotential(int unitId, int potentialSlot, bool setToAll, bool ignorePreset)
	{
		return default(UniTask<DeckResponseModel>);
	}

	public int GetDefaultPotential(int unitId)
	{
		return 0;
	}

	public void HandleDeckResponse(DeckResponseModel model)
	{
	}

	public void HandleBuildingResponse(BuildingResponseModel model)
	{
	}

	public void HandleShopResponse(ShopResponseModel model)
	{
	}

	public void HandleEventModeResponse(EventModeResponseModel model)
	{
	}

	public void HandleArtifactInventory(ArtifactInventoryResponseModel ret, bool handlePlayerCurrencies = true)
	{
	}

	public void HandleArtifactResult(ArtifactResultResponseModel ret, bool handlePlayerCurrencies = true)
	{
	}

	public void SetEquippedArtifactPreset(int deckPreset)
	{
	}

	public int GetEquippedArtifactPreset(ArtifactModel artifact)
	{
		return 0;
	}

	public void SetGold(int gold, string productId, string goldSpentTo, bool isFree, bool log = true)
	{
	}

	public void SetCash(int cash, string productId, string cashSpentTo, bool isFree, bool log = true)
	{
	}

	public void SetHeart(int heart, bool logging = true)
	{
	}

	public void SetGachaKeys(List<GachaKey> keys)
	{
	}

	public void SetGachaKeysWithoutCallback(List<GachaKey> keys)
	{
	}

	public bool SetGachaKey(int id, int count)
	{
		return false;
	}

	public int GetGachaKey(int keyId)
	{
		return 0;
	}

	public void SetGachaStack(GachaStack stack)
	{
	}

	public int GetGachaStack(int gachaId)
	{
		return 0;
	}

	public void SetArtifactGachaKey(int[] keys)
	{
	}

	public void SetArtifactGachaStack(int[] stacks)
	{
	}

	public void SetCashItems(ShopItemModel[] items)
	{
	}

	public void SetPlayerLevelExp(int level, int exp)
	{
	}

	public void HandleMissionsResponse(MissionResponseModel model)
	{
	}

	public void HandleRogueLikeOutGameResponse(RogueLikeOutGameDataResponseModel data)
	{
	}

	public void HandleRogueLikeMissionResponse(RogueLikeMissionDataResponseModel model)
	{
	}

	public void HandleRogueLikeMissionStatisticsResponse(RogueLikeMissionStatisticsResponseModel model)
	{
	}

	[AsyncStateMachine(typeof(_003CUpdateRogueLikeMission_003Ed__327))]
	public UniTask UpdateRogueLikeMission()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CLoadMissions_003Ed__328))]
	public void LoadMissions(Action callback)
	{
	}

	public void CheckMission(string condType, Action callback)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckMission_003Ed__330))]
	public void CheckMission(List<string> condTypes, Action callback)
	{
	}

	public MissionData GetMission(int id)
	{
		return null;
	}

	public List<MissionData> GetMissionWithCondition(int theme, string condType)
	{
		return null;
	}

	public bool CheckMissionFailWarning(int theme, string condType)
	{
		return false;
	}

	private bool CheckMissionType(MissionData missionData, string condType, int theme)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CGetMissionReward_003Ed__335))]
	public Task<MissionRewardResponseModel> GetMissionReward(int missionId, bool reloadAfterSuccess = true)
	{
		return null;
	}

	public void HandleInvasionRecords(InvasionRecordsResponseModel model)
	{
	}

	public void HandleInvasionRewardDatas(InvasionRewardDatasResponseModel model)
	{
	}

	public bool HasInvasionPass(int passIndex, int pass)
	{
		return false;
	}

	public bool InvasionRewardReceived(int theme, int difficulty, int pass)
	{
		return false;
	}

	public void HandleInvasionRewardReceived(int theme, int pass, long rewardState)
	{
	}

	public InvasionRewardDatasResponseModel.RewardData GetInvasionRewardData(int theme, int pass)
	{
		return null;
	}

	public List<InvasionRewardDatasResponseModel.RewardData> GetInvasionRewardDatasByPassIndex(int passIndex)
	{
		return null;
	}

	public int GetCurrentEventDifficulty(int theme)
	{
		return 0;
	}

	public void SetCurrentEventDifficulty(int theme, int value)
	{
	}

	public int GetCurrentEventMaxDifficulty(int theme)
	{
		return 0;
	}

	public void SetCurrentEventMaxDifficulty(int theme, int value)
	{
	}

	public int GetInvasionClearedDifficulty(int theme)
	{
		return 0;
	}

	public int GetInvasionUnlockedDifficulty(int theme)
	{
		return 0;
	}

	public bool IsClearedTheme(int theme, int difficulty = 0)
	{
		return false;
	}

	public int GetEliteLevelSum()
	{
		return 0;
	}

	public int GetProfileIconId()
	{
		return 0;
	}

	public int GetProfileBackgroundId()
	{
		return 0;
	}

	public void SetProfileIconId(int id)
	{
	}

	public int GetRemainAdRefreshDailyShopCount()
	{
		return 0;
	}

	public void SetRemainAdRefreshDailyShopCount(int value)
	{
	}

	public int GetRemainCashRefreshDailyShopCount()
	{
		return 0;
	}

	public void SetRemainCashRefreshDailyShopCount(int value)
	{
	}

	public Popup GetPopup()
	{
		return null;
	}

	public void ShowLoading(bool v)
	{
	}

	public void HandlePostResponse(PostResponseModel model)
	{
	}

	public void HandlePostReceiveResponse(PostReceiveResponseModel model)
	{
	}

	public List<Reward> HandleRewardListResponseData(RewardListResponseData rewardListData, bool showCenterText = false, string spentTo = null)
	{
		return null;
	}

	private Reward HandleRewardResponseData(RewardResponseData rewardData, string spentTo = null)
	{
		return default(Reward);
	}

	public CustomEventData GetCustomEventData(string name)
	{
		return null;
	}

	public bool IsAttendedCustomEvent(string key)
	{
		return false;
	}

	public string GetKeyValue(string key)
	{
		return null;
	}

	public void SetKeyValue(string key, string value)
	{
	}

	public void SetOrAddKeyValue(string key, string value)
	{
	}

	public bool GetKeyValueBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public int GetKeyValueInt(string key, int defaultValue = 0)
	{
		return 0;
	}

	public void HandleTokenInfos(List<TokenInfo> tokens)
	{
	}

	public void HandlePlayerTerritoryTycoon(PlayerTerritoryTycoonResponseModel model, bool showEffect = false)
	{
	}

	private void ShootGetSpecialSeasonalTokenEffect(ResourceShopItem.SpecialSeasonalTokenType type, int diff)
	{
	}

	public void SetToken(string type, int count)
	{
	}

	public void SetTokenCount(string type, int count)
	{
	}

	public int GetTokenCount(string type)
	{
		return 0;
	}

	public int GetSpecialSeasonalEventTokenCount(ResourceShopItem.SpecialSeasonalTokenType type)
	{
		return 0;
	}

	public bool HasEventPoint(int price)
	{
		return false;
	}

	public bool HasArtifactValue(string type, BattleManager battle)
	{
		return false;
	}

	public List<ResourceArtifact.TileBuff> GetArtifactTileBuffs(BattleManager battle, List<ArtifactModel> artifacts = null)
	{
		return null;
	}

	public string GetArtifactValueText(string type, BattleManager battle)
	{
		return null;
	}

	public int GetArtifactValueMax(string type, BattleManager battle)
	{
		return 0;
	}

	public int GetArtifactValueSum(string type, BattleManager battle)
	{
		return 0;
	}

	public float GetArtifactValueSumFloat(string type, BattleManager battle)
	{
		return 0f;
	}

	public int GetArtifactOptionSum(List<ArtifactModel> artifacts, int unitPos, string type)
	{
		return 0;
	}

	public int GetArtifactValueSumFromDeck(PvPDeckInfo deck, string type)
	{
		return 0;
	}

	public bool HasArtifactValueFromList(List<ArtifactModel> artifacts, string type)
	{
		return false;
	}

	public string GetArtifactValueTextFromList(List<ArtifactModel> artifacts, string type)
	{
		return null;
	}

	public float GetArtifactValueSumFromList(List<ArtifactModel> artifacts, string type)
	{
		return 0f;
	}

	public int GetUnitExpItemCount()
	{
		return 0;
	}

	public void SetUnitExpItem(int value)
	{
	}

	public bool HasSoulItem(int count)
	{
		return false;
	}

	public int GetUnitSoulItemCount()
	{
		return 0;
	}

	public void SetUnitSoulItem(int value)
	{
	}

	public void AddFlag(FlagResponseModel model)
	{
	}

	public void AddNameTag(NameTagResponseModel model)
	{
	}

	public void AddTerritoryBuilding(PlayerTerritoryResponseModel.StoredBuilding building)
	{
	}

	public void SetBoughtRogueLikeDLCs(string dlcs)
	{
	}

	public int GetNewUnitGachaItemCount()
	{
		return 0;
	}

	public void SetNewUnitGachaItem(int value)
	{
	}

	public int GetSelectedTreasureGachaCeilId(ResourceGacha resGacha)
	{
		return 0;
	}

	private int GetStatusItemCount(string key)
	{
		return 0;
	}

	private void SetStatusItem(string key, int value, int ratio, GetMoneyEffect effect = null)
	{
	}

	public int GetDeckSlotCount()
	{
		return 0;
	}

	public void SetDeckSlotCount(int value)
	{
	}

	public void HandleSetDeckSlotName(int index, string name)
	{
	}

	public string GetDeckSlotName(int index)
	{
		return null;
	}

	public void HandleSeasonPass(SeasonPassResponseModel ret)
	{
	}

	public bool PassBonusAllReceived()
	{
		return false;
	}

	public void HandleSeasonPassEventBooster(SeasonPassEventBoosterResponseModel ret)
	{
	}

	public void HandlePvpInfo(PvPInfoResponseModel ret)
	{
	}

	public void HandleFourthYearEvent(FourthYearEventResponseModel ret)
	{
	}

	public void HandleLogout()
	{
	}

	public bool CanPassAd()
	{
		return false;
	}

	public bool CanUseReviveCoupon()
	{
		return false;
	}

	public bool CanReturnEventAd()
	{
		return false;
	}

	public void ReloadSeasonPassPanel()
	{
	}

	public void ReloadFourthYearEvent()
	{
	}

	[AsyncStateMachine(typeof(_003CCheckXcd_003Ed__419))]
	public void CheckXcd()
	{
	}

	public void HandleClan(ClanResponseModel model)
	{
	}

	public void HandleClan(ClanModel clan, int role)
	{
	}

	public void HandleClan(ClanModel clan, int role, DateTime requestSupportCooltime, DateTime canPlayClanRaidAt, DateTime clanRaidLockedByLeaveUntilAt, ClanSupportCompletedModel supportCompletedModel = null)
	{
	}

	public bool NewClanJoinRequest()
	{
		return false;
	}

	public bool CanClanSupportRequest()
	{
		return false;
	}

	public bool IsClanNameBanned()
	{
		return false;
	}

	public bool IsClanTagUnset()
	{
		return false;
	}

	public bool CanMandateMaster()
	{
		return false;
	}

	public string GetClanTagText(ClanModel clanModel)
	{
		return null;
	}

	private bool CheckDeckNameValidity(string name)
	{
		return false;
	}

	public void HandleFlagInventory(FlagInventoryResponseModel model)
	{
	}

	public void EquipFlag(FlagResponseModel model)
	{
	}

	public void HandleNameTagInventory(NameTagInventoryResponseModel model)
	{
	}

	public void EquipNameTag(NameTagResponseModel model)
	{
	}

	public int GetEquippedNameTagId()
	{
		return 0;
	}

	public void InitRogueLike()
	{
	}

	public bool CanAddRogueLikeCard()
	{
		return false;
	}

	public RogueLikeCardData GetRogueLikeCard(int id)
	{
		return null;
	}

	public void AddRogueLikeCard(int unitId)
	{
	}

	public void AddRogueLikeCard(RogueLikeCardData card)
	{
	}

	public void AddRogueLikeCardToListOnly(RogueLikeCardData card)
	{
	}

	public void AfterRogueLikeCardsModified()
	{
	}

	public void RemoveRogueLikeCard(RogueLikeCardData card)
	{
	}

	public RogueLikeCardData FindRogueLikeCard(Predicate<RogueLikeCardData> func)
	{
		return null;
	}

	public List<RogueLikeCardData> FindRogueLikeCards(Predicate<RogueLikeCardData> func)
	{
		return null;
	}

	public List<RogueLikeCardData> GetAllRogueLikeCards()
	{
		return null;
	}

	private void OnRogueLikeCardLevelUp(RogueLikeCardData card, int prevLevel)
	{
	}

	public void AddRogueLikeCardExp(RogueLikeCardData card, int amount, bool checkLevelUp)
	{
	}

	public bool CanAddRogueLikeArtifact()
	{
		return false;
	}

	public void AddRogueLikeArtifact(ResourceArtifact resArtifact)
	{
	}

	public void AddRogueLikeArtifact(RogueLikeArtifactModel model)
	{
	}

	public void AddRogueLikeArtifact(ResourceArtifact resArtifact, RogueLikeArtifactModel model)
	{
	}

	public void RemoveRogueLikeArtifact(RogueLikeArtifactModel model)
	{
	}

	public void UpgradeRogueLikeArtifact(RogueLikeArtifactModel model)
	{
	}

	public void AddRogueLikeArtifactToListOnly(RogueLikeArtifactModel model)
	{
	}

	public void AfterRogueLikeArtifactsModified()
	{
	}

	public List<RogueLikeArtifactModel> GetAllRogueLikeArtifacts()
	{
		return null;
	}

	public bool RogueLikeDidSelectedBuildingArtifact()
	{
		return false;
	}

	public bool RogueLikeDidIgnoredAllBuildingArtifactRooms()
	{
		return false;
	}

	public void ReloadRogueLikeBuildingLevels()
	{
	}

	public void AfterReloadRogueLikeBuildings()
	{
	}

	public bool CheckGodItemsAndShowGodItemSelectPanel()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CHandleMissionReward_003Ed__462))]
	public void HandleMissionReward(MissionRewardResponseModel model)
	{
	}

	public void HandlePlayerTerritory(PlayerTerritoryResponseModel model)
	{
	}

	public void ReloadTerritoryBuildingsUnitAssignBenefit()
	{
	}

	public void HandlePlayerColosseum(PlayerColosseumInfoResponseModel model)
	{
	}

	public int GetLeagueSeason()
	{
		return 0;
	}

	public void HandleTerritoryStatBuffPerModel(int[] statBuffPers)
	{
	}

	public float GetTerritoryBuildingAssignedUnitsBenefitPerWithBonus(TerritoryBuildingData buildingData)
	{
		return 0f;
	}

	public float GetTerritoryBuildingAssignedUnitsBenefitPerWithBonus(ResourceTerritoryBuilding resBuilding, List<int> assignedUnits)
	{
		return 0f;
	}

	public float GetTerritoryBuildingAssignedUnitsBenefitPer(ResourceTerritoryBuilding resBuilding, List<int> assignedUnits)
	{
		return 0f;
	}

	public float GetTerritoryBuildingAssignedUnitBenefitPer(CardData card, bool isManager)
	{
		return 0f;
	}

	public float GetTerritoryBuildingAssignedUnitsRoleBonusPer(ResourceTerritoryBuilding resBuilding, List<int> assignedUnits)
	{
		return 0f;
	}

	public int GetTerritoryBuildingAssignedUnitsManagerIndex(ResourceTerritoryBuilding resBuilding, List<int> assignedUnits)
	{
		return 0;
	}

	public int GetTerritoryBuildingAssignedUnitsManagerIndex(ResourceTerritoryBuilding resBuilding, List<CardData> cards)
	{
		return 0;
	}

	public void AddOrUpdateTerritoryBuilding(TerritoryBuildingData prevData, TerritoryBuildingData data)
	{
	}

	public void RemoveTerritoryBuilding(TerritoryBuildingData buildingData)
	{
	}

	public void StoreTerritoryBuilding(int buildingId)
	{
	}

	public void UnStoreTerritoryBuilding(int buildingId)
	{
	}

	public int GetStoredTerritoryBuildingCount(int buildingId)
	{
		return 0;
	}

	public void HandleTerritoryBuildingAssignedUnits(TerritoryBuildingData buildingData, List<int> prevUnits, List<int> units)
	{
	}

	public void HandlePlayerLevelSyncData(List<TerritoryLevelSyncData> playerLevelSyncData)
	{
	}

	public void SetTerritoryLabor(int labor, bool reloadLabor)
	{
	}

	public bool HasLabor(int price)
	{
		return false;
	}

	public void SetTerritoryStoredLabor(int storedLabor, bool reloadLabor)
	{
	}

	public void SetTerritoryBuildingCore(int core)
	{
	}

	public void SetTerritoryTownHallCore(int core)
	{
	}

	public bool IsMaxTerritoryStoredLabor()
	{
		return false;
	}

	public int GetMaxTerritoryLabor()
	{
		return 0;
	}

	public int GetMaxTerritoryStoredLabor()
	{
		return 0;
	}

	public int GetLaborGenAmount()
	{
		return 0;
	}

	public TerritoryBuildingData GetTerritoryBuildingDataByRoot(int rootId)
	{
		return null;
	}

	public void ReloadTerritoryUnitsLaborTimer(List<CardData> cards)
	{
	}

	public void ReloadTerritoryUnitsSkinTokenTimer(List<CardData> cards)
	{
	}

	public bool CanCollectTerritoryLabor()
	{
		return false;
	}

	public void CollectLaborFromTerritoryUnit(int unitId)
	{
	}

	public void CollectSkinTokenFromTerritoryUnit(int unitId)
	{
	}

	private int GetRandomUnitIdForTerritoryLaborTimer()
	{
		return 0;
	}

	private int GetRandomUnitIdForTerritorySkinTokenTimer()
	{
		return 0;
	}

	public bool CanShowTerritoryUnitLaborMarker(int unitId)
	{
		return false;
	}

	public bool CanShowTerritoryUnitSkinTokenMarker(int unitId)
	{
		return false;
	}

	public float GetUnitsStatBuffPerFromTerritory(Constants.TerritoryStatBuffType type)
	{
		return 0f;
	}

	public float[] GetTerritoryStatBuffPers()
	{
		return null;
	}

	private bool CanApplyTerritoryStatBuffPer(int themeId)
	{
		return false;
	}

	public void FetchTerritoryStatBuffs()
	{
	}

	public int CalculateTerritoryHuntingUnitsCombatPower(List<int> units)
	{
		return 0;
	}

	public int CalculateTerritoryHuntingUnitCombatPower(CardData card)
	{
		return 0;
	}

	public ResourceTerritoryHunting.TerritoryHuntingRank PredictTerritoryHuntingRank(ResourceTerritoryHunting resHunting, int combatPower)
	{
		return default(ResourceTerritoryHunting.TerritoryHuntingRank);
	}

	public int CalculateTerritoryHuntingRankBonus(ResourceTerritoryHunting.TerritoryHuntingRank rank)
	{
		return 0;
	}

	public int CalculateTerritoryHuntingRegionBonus(ResourceUnit.Region region, List<int> units)
	{
		return 0;
	}

	public List<Reward> GetTerritoryHuntingRewards(TerritoryHuntingData huntingData, int difficulty, ResourceTerritoryHunting.TerritoryHuntingRank rank, float rewardPer)
	{
		return null;
	}

	public void HandlePlayerSeasonalEventData(PlayerSeasonalEventDataResponseModel model)
	{
	}

	public void SetSeasonalEventToken(int consumableToken = -1, int gachaToken = -1, int skinToken = -1, int storedSkinToken = -1, bool collectSkin = false)
	{
	}

	public void HandleTreasureInventory(TreasureInventoryResponseModel ret)
	{
	}

	public void HandleTreasureResult(TreasureResultResponseModel ret, bool handlePlayerCurrencies, bool newAdded = false)
	{
	}

	public void HandleAccessoryInventory(AccessoryInventoryResponseModel ret)
	{
	}

	public void HandleAccessoryResult(AccessoryResultResponseModel ret, bool handlePlayerCurrencies, bool newAdded = false)
	{
	}

	private void HandleAccessoryResultInEarlyAccessMode(AccessoryResultResponseModel ret)
	{
	}

	public List<ResourceTheme> GetSeasonalEventModes()
	{
		return null;
	}

	public int GetSeasonalEventModeCount()
	{
		return 0;
	}

	public int GetSeasonalEventModePlayCount(int modeID = -1)
	{
		return 0;
	}

	public ResourceShopItem GetCurrentNewHeroSkinPackage()
	{
		return null;
	}

	public void SetSeasonalEventModePlayCount(int modeID, int count, bool showDiffEffect = true)
	{
	}

	public bool HasSkin(int skinID)
	{
		return false;
	}

	public void AddSkin(int unitId, int skinId)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchOtherClan_003Ed__527))]
	public UniTask<ClanResponseModel> FetchOtherClan(int clanId)
	{
		return default(UniTask<ClanResponseModel>);
	}

	public List<ArtifactModel> GetEquippedArtifacts()
	{
		return null;
	}

	public List<ArtifactModel> GetEnemyEquippedArtifacts()
	{
		return null;
	}

	public ArtifactModel GetArtifact(int id)
	{
		return null;
	}

	public ArtifactModel GetArtifactByArtifactId(int targetId, int artifactId)
	{
		return null;
	}

	public bool HasClan()
	{
		return false;
	}

	public bool CheckPvPEnabled()
	{
		return false;
	}

	public bool CheckColosseumEnabled()
	{
		return false;
	}

	public void SetProfileUI(ProfileUIInfo profileUIInfo)
	{
	}

	public bool CanTransferAccount()
	{
		return false;
	}

	public int GetTransferAccountLeftDay()
	{
		return 0;
	}

	public void SetEffectsSpawnTarget(Transform target, Vector3 offset = default(Vector3))
	{
	}

	public void HandleBuyResponse(BuyResponseModel model)
	{
	}

	public void HandleUseInventoryResponse(UseInventoryResponseModel model)
	{
	}

	public bool IsAllCardHasMaxLvSoul(int additionalMaxLimit = 0)
	{
		return false;
	}

	public int GetRegionUnitCount(ResourceUnit.Region region)
	{
		return 0;
	}

	public void HandleInventoryResponse(InventoryResponseModel model)
	{
	}

	public void AddInventoryItem(int id, int count)
	{
	}

	public void SetInventoryItem(int id, int count)
	{
	}

	public void HandleInventoryItem(InventoryItem inventoryItem)
	{
	}

	public void HandleInventoryItems(List<InventoryItem> inventoryItems)
	{
	}

	public int GetInventoryItemCount(int id)
	{
		return 0;
	}

	public void SetInventoryItemCount(int id, int count)
	{
	}

	public bool HasInventoryItem(int id, int count)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoadScene_003Ed__554))]
	public void LoadScene(string scene, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
	{
	}

	public AsyncOperation LoadSceneAsync(string scene, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
	{
		return null;
	}

	private bool ChangeSceneBetweenAdditiveScenes(string name)
	{
		return false;
	}

	public int GetActivePostCount()
	{
		return 0;
	}

	public void SaveRogueLike(int slot = -1, bool ignoreScene = false)
	{
	}

	public bool LoadRogueLike(int slot = -1)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CSaveRogueLikeToServer_003Ed__560))]
	public UniTask SaveRogueLikeToServer(bool restoreFromLastSave = false)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CLoadRogueLikeFromServer_003Ed__561))]
	public void LoadRogueLikeFromServer()
	{
	}

	[AsyncStateMachine(typeof(_003CDeleteRogueLikeSaveDataWithoutLogging_003Ed__562))]
	public UniTask DeleteRogueLikeSaveDataWithoutLogging()
	{
		return default(UniTask);
	}

	private void HandleDeleteRogueLikeData(DeleteRogueLikeDataResponseModel ret)
	{
	}

	private void BindStatusToMission()
	{
	}

	public void SetCheckRogueLikeMissionFlag()
	{
	}

	public void RemoveRogueLikeCheckMissionPending()
	{
	}

	public bool CanCheckRogueLikeMission()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CWaitForCompleteAndCheckRogueLikeMission_003Ed__568))]
	public UniTask WaitForCompleteAndCheckRogueLikeMission()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CCheckRogueLikeMission_003Ed__569))]
	public UniTask CheckRogueLikeMission()
	{
		return default(UniTask);
	}

	public void CollectRune(int id)
	{
	}

	public bool IsNightPushOff()
	{
		return false;
	}

	public TimeSpan GetPushFireTime(int id)
	{
		return default(TimeSpan);
	}

	public void FlushAlarm()
	{
	}

	public void MakeAlarm()
	{
	}

	public bool HasUncheckedRogueLikeMission()
	{
		return false;
	}

	public bool IsRogueLikeMissionChecked(int id)
	{
		return false;
	}

	public void SetAllRogueLikeMissionChecked()
	{
	}

	public bool CheckArtifactCompatibility(ArtifactModel target, ArtifactModel equipped, bool isExchange)
	{
		return false;
	}

	public void CheckArtifactDeckCondition(ResourceArtifact resArtifact, List<int> unitIdList)
	{
	}

	public int GetSyncLevel(ResourceTerritoryBuilding territoryBuilding, List<int> cards)
	{
		return 0;
	}

	public bool IsGodSkinAvailable(int skinId)
	{
		return false;
	}

	public bool AlreadyHasGodSkinPackage1(int skinId)
	{
		return false;
	}

	public int[] GetDefaultRogueLikeBuildings()
	{
		return null;
	}

	public bool IsHardModeShopUnlocked()
	{
		return false;
	}

	public bool CanPlayHardMode()
	{
		return false;
	}

	public bool CanGacha(ResourceGacha resGacha)
	{
		return false;
	}

	public int[] GetPotentials()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CStartColosseumMatchmaking_003Ed__588))]
	public UniTaskVoid StartColosseumMatchmaking()
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003CFetchAssignment_003Ed__589))]
	private Task<bool> FetchAssignment()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CTestStartColosseumMatchMaking_003Ed__590))]
	public UniTaskVoid TestStartColosseumMatchMaking(bool isSingle, int botNum = 0)
	{
		return default(UniTaskVoid);
	}

	public void SetMatchMakingVisible(bool set)
	{
	}

	[AsyncStateMachine(typeof(_003CAfterMatchComplete_003Ed__592))]
	private UniTaskVoid AfterMatchComplete(string endPoint)
	{
		return default(UniTaskVoid);
	}

	public void SetMatchLock(bool v)
	{
	}

	public void EnterColosseumServer()
	{
	}

	[AsyncStateMachine(typeof(_003CCancelMatchmaking_003Ed__595))]
	public UniTaskVoid CancelMatchmaking()
	{
		return default(UniTaskVoid);
	}

	private void AfterCancelMatch()
	{
	}

	public bool IsInMatchmaking()
	{
		return false;
	}

	public bool CheckIsInMatchmakingAndShowCenterText(int themeToStart = -1)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CDispatchReenterWebSocketEvent_003Ed__599))]
	public void DispatchReenterWebSocketEvent(BaseMessage message)
	{
	}

	[AsyncStateMachine(typeof(_003CDispatchMatchmakingWebSocketEvent_003Ed__600))]
	private void DispatchMatchmakingWebSocketEvent(BaseMessage message)
	{
	}

	public void OnWebSocketClosed(WebSocketCloseStatus? closeStatus)
	{
	}

	[AsyncStateMachine(typeof(_003CInstantiateAudioController_003Ed__602))]
	public void InstantiateAudioController(bool async = false, Action OnCompleted = null)
	{
	}

	public void ReloadAudioVolume()
	{
	}

	public void InstantiateSimpleAssetDB()
	{
	}

	public bool IsReturnEventAvailable()
	{
		return false;
	}

	public bool IsThirdHalfAnniversaryMissionAvailable()
	{
		return false;
	}

	public bool IsFourthYearEventAvailable()
	{
		return false;
	}

	public bool IsPreSeason()
	{
		return false;
	}

	public List<string> CurrentHolidayTypes()
	{
		return null;
	}

	public DateTime CurrentHolidayUntilAt(string holiday)
	{
		return default(DateTime);
	}

	public bool SkinBundlePackageSoldOut(int itemId)
	{
		return false;
	}

	public CardData GetHighestLevelCard()
	{
		return null;
	}

	public TreasureModel FindTreasure(int id)
	{
		return null;
	}

	public TreasureModel GetEquippedTreasure(int unitId)
	{
		return null;
	}

	public AccessoryModel FindAccessory(int id)
	{
		return null;
	}

	public List<AccessoryModel> GetEquippedAccessories(int unitId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CEquipTreasure_003Ed__618))]
	public UniTask<TreasureResultResponseModel> EquipTreasure(int unitID, int treasureID)
	{
		return default(UniTask<TreasureResultResponseModel>);
	}

	public (bool, int) GetTreasureUnlockPrice(TreasureModel treasure)
	{
		return default((bool, int));
	}

	[AsyncStateMachine(typeof(_003CCanEquipTreasureCheck_003Ed__620))]
	public UniTask<MultiPriceButtonPopup.Response> CanEquipTreasureCheck(TreasureModel treasure, bool showAlert, int unitID = -1, ConditionalBase cond = null)
	{
		return default(UniTask<MultiPriceButtonPopup.Response>);
	}

	[AsyncStateMachine(typeof(_003CSetTreasureState_003Ed__621))]
	public UniTask<TreasureResultResponseModel> SetTreasureState(TreasureModel treasure, int state)
	{
		return default(UniTask<TreasureResultResponseModel>);
	}

	public (bool, int) GetAccessoryUnlockPrice(List<AccessoryModel> accessories)
	{
		return default((bool, int));
	}

	[AsyncStateMachine(typeof(_003CSetAccessoryState_003Ed__623))]
	public UniTask<AccessoryResultResponseModel> SetAccessoryState(AccessoryModel accessory, int state)
	{
		return default(UniTask<AccessoryResultResponseModel>);
	}

	public int GetMaxInventoryCount(string inventoryType)
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003CAddInventoryCount_003Ed__625))]
	public UniTask<PlayerInventoryCountResponseModel> AddInventoryCount(string inventoryType, int count)
	{
		return default(UniTask<PlayerInventoryCountResponseModel>);
	}

	public bool CanConsumeItem(Reward reward)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CDismantleAccessoriesImpl_003Ed__627))]
	public UniTask<(Dictionary<int, int>, AccessoryResultResponseModel)> DismantleAccessoriesImpl(HashSet<int> accessoryDismantleInfo, Func<int, Dictionary<int, int>, bool, UniTask<bool>> alertTaskFunc)
	{
		return default(UniTask<(Dictionary<int, int>, AccessoryResultResponseModel)>);
	}

	public int GetAvailableStreamingIndex(bool preview = false)
	{
		return 0;
	}

	public RewardListResponseData HandleGameResponse_Reward(GameResponseModel ret, int theme)
	{
		return null;
	}

	private void AddPassPoint(int amount)
	{
	}

	public void HandleGameSkipInformation(GameSkipInfoResponseModel ret)
	{
	}

	public bool IsArtifactInventoryFull(int theme)
	{
		return false;
	}

	public bool IsAccessoryInventoryFull(int theme)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CCheckStartGameValidate_003Ed__634))]
	public UniTask<bool> CheckStartGameValidate(GameStartRequestModel.DeckInfo deckInfo, bool checkArtifact, bool checkBuilding)
	{
		return default(UniTask<bool>);
	}

	public Camera GetTargetRenderCamera(MonoBehaviour obj)
	{
		return null;
	}

	public Camera GetCanvasRenderCamera(Canvas canvas)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGameSkipCheckAndShortcut_003Ed__637))]
	public void GameSkipCheckAndShortcut()
	{
	}

	public List<ResourceTreasure> GetPermanentGachaTreasures(ResourceTreasure.Rarity rarity)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCheckTreasureWishListValid_003Ed__639))]
	public UniTask<bool> CheckTreasureWishListValid()
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(_003CFetchTreasureWishList_003Ed__640))]
	public void FetchTreasureWishList(Action onFetchCompleted = null)
	{
	}

	public void SetAlphaRaycasterEnabled(bool enabled)
	{
	}
}

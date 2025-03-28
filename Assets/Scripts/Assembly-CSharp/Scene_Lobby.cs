using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AlphaRaycaster;
using Awesomepiece.Model;
using Crystal;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Lobby : Scene_Base
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public Scene_Lobby _003C_003E4__this;

		public bool processed;

		internal void _003CCheckColosseumReenter_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckColosseumReenter_003Ed__136 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public Scene_Lobby _003C_003E4__this;

		private _003C_003Ec__DisplayClass136_0 _003C_003E8__1;

		private string _003ClastGameID_003E5__2;

		private string _003CsessionID_003E5__3;

		private ColosseumMatchResponseModel _003Cret_003E5__4;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<ColosseumEndGameReenterResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__3;

		private UniTask<ColosseumPlayerDataResponseModel>.Awaiter _003C_003Eu__4;

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
	private struct _003CCheckLastGameCompleteRequest_003Ed__134 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Lobby _003C_003E4__this;

		private UniTask<GameResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CCheckPatchVersion_003Ed__102 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	private struct _003CFetchAccessoryInventory_003Ed__114 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask<AccessoryInventoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchAllCards_003Ed__127 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<CardListResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchArtifactInventory_003Ed__113 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask<ArtifactInventoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchBabel_003Ed__126 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		private UniTask<BabelResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchCard_003Ed__128 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int cardID;

		private UniTask<CardResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchClan_003Ed__123 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	private struct _003CFetchClanRaid_003Ed__124 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<ClanRaidResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchClanRaidWait_003Ed__125 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private UniTask<ClanRaidResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchDailyAttendanceEvents_003Ed__122 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Lobby _003C_003E4__this;

		private UniTask<DailyAttendanceEventsResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchEventMode_003Ed__112 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public bool reloadUI;

		private UniTask<EventModeResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchFourthYearEvent_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask<FourthYearEventResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchInventory_003Ed__130 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<InventoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchMission_003Ed__118 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	private struct _003CFetchPlayerCurrencies_003Ed__108 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<PlayerCurrenciesResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchPlayerDailyConsumedCurrencies_003Ed__109 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<PlayerCurrenciesResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchPlayerInfo_003Ed__107 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<PlayerDataResponseModel> _003C_003Et__builder;

		public Scene_Lobby _003C_003E4__this;

		public bool handlePlayerCurrencies;

		private UniTask<PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchPost_003Ed__117 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask<PostResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchSeasonPass_003Ed__119 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public Scene_Lobby _003C_003E4__this;

		public Action callback;

		private UniTask<SeasonPassResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchSeasonPassEventBooster_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<SeasonPassEventBoosterResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchShop_003Ed__111 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask<ShopResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchTerritory_003Ed__129 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<PlayerTerritoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchTreasureInventory_003Ed__115 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask<TreasureInventoryResponseModel>.Awaiter _003C_003Eu__1;

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

	public static Scene_Lobby Instance;

	public global::AlphaRaycaster.AlphaRaycaster alphaRaycaster;

	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public ScreenScroller screenScroller;

	public ConditionalGroup earlyAccessModeCond;

	public PreButtonHandler baseCanvasButtonBlocker;

	public PreButtonHandler popupCanvasButtonBlocker;

	public PreButtonHandler overlayCanvasButtonBlocker;

	[ComponentConnect]
	public GameObject background;

	[ComponentConnect]
	public CanvasGroup top;

	[ComponentConnect]
	public CanvasGroup main;

	[ComponentConnect]
	public CanvasGroup bottom;

	[ComponentConnect]
	public SafeArea safeArea;

	[ComponentConnect]
	public SafeArea outerUISafeArea;

	[ComponentConnect]
	public SafeArea tutorialSafeArea;

	[ComponentConnect]
	public Image black;

	[ComponentConnect]
	public Image blackBack;

	[ComponentConnect]
	public Image topGradation;

	[ComponentConnect("Bottom", true)]
	public TabManager tabManager;

	[ComponentConnect]
	public OutgameTutorialPanel outgameTutorialPanel;

	[ComponentConnect]
	public RectTransform flagButton;

	public ItemTooltipPanel itemTooltipPanel;

	public AccessorySynergyToolTip accessorySynergyToolTip;

	[HideInInspector]
	public bool popupDisplayed;

	private AttPopup _attPopup;

	private NicknameChangePopup _nicknameChangePopup;

	private VoidedPurchasePanel _voidedPurchasePanel;

	private NewUnitPopup _newUnitPopup;

	private NewUnitPackagePanel _newUnitPackagePanel;

	private PopupPackagePopup _popupPackagePopup;

	private PvPDormantPanel _pvpDormantPanel;

	private SelectDeckPresetPopup _selectDeckPresetPopup;

	private TerritoryPassPanel _territoryPassPanel;

	private InventoryPanel _inventoryPanel;

	private TreasureInfoPanel _treasureInfoPanel;

	private AccessoryInfoPanel _accessoryInfoPanel;

	private AccessoryEquipPanel _accessoryEquipPanel;

	private RewardBoxInventoryPanel _rewardBoxInventoryPanel;

	private RewardListResultPanel _rewardListResultPanel;

	private StatInformationPopup _statInformationPopup;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	private AdOrPassPopup _adOrPassPopup;

	private TreasureWishListPanel _treasureWishListPanel;

	public MultiPriceButtonPopup multiPriceButtonPopup;

	public GameObject defaultFlagObj;

	public Transform popupHierachyIndexer;

	public Transform popupHierachyIndexer2;

	private Sequence _blackSequence;

	private bool _ready;

	private List<TweenTab> _tweenTabs;

	private int _blockEscape;

	private DateTime _lastSecondIntervalUpdateCheckedAt;

	private static ulong _bgmFadeHash;

	public AttPopup attPopup => null;

	public NicknameChangePopup nicknameChangePopup => null;

	public VoidedPurchasePanel voidedPurchasePanel => null;

	[HideInInspector]
	public NewUnitPopup newUnitPopup => null;

	[HideInInspector]
	public NewUnitPackagePanel newUnitPackagePanel => null;

	[HideInInspector]
	public PopupPackagePopup popupPackagePopup => null;

	public PvPDormantPanel pvpDormantPanel => null;

	public SelectDeckPresetPopup selectDeckPresetPopup => null;

	public TerritoryPassPanel territoryPassPanel => null;

	public InventoryPanel inventoryPanel => null;

	public TreasureInfoPanel treasureInfoPanel => null;

	public AccessoryInfoPanel accessoryInfoPanel => null;

	public AccessoryEquipPanel accessoryEquipPanel => null;

	public RewardBoxInventoryPanel rewardBoxInventoryPanel => null;

	public RewardListResultPanel rewardListResultPanel => null;

	public StatInformationPopup statInformationPopup => null;

	public TerritoryBonusUnitTooltip territoryBonusUnitTooltip => null;

	public AdOrPassPopup adOrPassPopup => null;

	public TreasureWishListPanel treasureWishListPanel => null;

	public int popupHierachyIndex => 0;

	public int popupHierachyIndex_Top => 0;

	public int popupHierachyIndex_Top2 => 0;

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	protected override void OnResolutionChanged(float resolution)
	{
	}

	private void SetResolution()
	{
	}

	public void Init()
	{
	}

	public void InstantiateFlag(ResourceFlag flag, int season)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckPatchVersion_003Ed__102))]
	private void CheckPatchVersion()
	{
	}

	private void OnClickTab(int idx)
	{
	}

	public void ShowBlack(bool show, Action onComplete = null, float time = 0.5f, float maxAlpha = 1f, bool remainBlack = false)
	{
	}

	public void StartGame()
	{
	}

	public void SetScreenDragEnabled(bool v)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchPlayerInfo_003Ed__107))]
	public UniTask<PlayerDataResponseModel> FetchPlayerInfo(bool handlePlayerCurrencies = true)
	{
		return default(UniTask<PlayerDataResponseModel>);
	}

	[AsyncStateMachine(typeof(_003CFetchPlayerCurrencies_003Ed__108))]
	public void FetchPlayerCurrencies()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchPlayerDailyConsumedCurrencies_003Ed__109))]
	public void FetchPlayerDailyConsumedCurrencies()
	{
	}

	public void HandlePopupAndEvents()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchShop_003Ed__111))]
	public UniTask FetchShop()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchEventMode_003Ed__112))]
	public void FetchEventMode(bool reloadUI = false)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchArtifactInventory_003Ed__113))]
	public UniTask FetchArtifactInventory()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchAccessoryInventory_003Ed__114))]
	public UniTask FetchAccessoryInventory()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchTreasureInventory_003Ed__115))]
	public UniTask FetchTreasureInventory()
	{
		return default(UniTask);
	}

	public void ReloadPanels()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchPost_003Ed__117))]
	public UniTask FetchPost()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchMission_003Ed__118))]
	public void FetchMission()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchSeasonPass_003Ed__119))]
	public UniTask FetchSeasonPass(Action callback = null)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchSeasonPassEventBooster_003Ed__120))]
	public void FetchSeasonPassEventBooster()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchFourthYearEvent_003Ed__121))]
	public UniTask FetchFourthYearEvent()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchDailyAttendanceEvents_003Ed__122))]
	public void FetchDailyAttendanceEvents()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchClan_003Ed__123))]
	public void FetchClan()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchClanRaid_003Ed__124))]
	public void FetchClanRaid()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchClanRaidWait_003Ed__125))]
	public Task FetchClanRaidWait()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CFetchBabel_003Ed__126))]
	public UniTaskVoid FetchBabel()
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003CFetchAllCards_003Ed__127))]
	public void FetchAllCards()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchCard_003Ed__128))]
	public void FetchCard(int cardID)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchTerritory_003Ed__129))]
	public void FetchTerritory()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchInventory_003Ed__130))]
	public void FetchInventory()
	{
	}

	public new void Update()
	{
	}

	public void SetBlockEscape(bool set)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckLastGameCompleteRequest_003Ed__134))]
	private void CheckLastGameCompleteRequest()
	{
	}

	private void CheckSavedGame()
	{
	}

	[AsyncStateMachine(typeof(_003CCheckColosseumReenter_003Ed__136))]
	private UniTaskVoid CheckColosseumReenter()
	{
		return default(UniTaskVoid);
	}

	public void OnReenterClosed(WebSocketCloseStatus? closeStatus)
	{
	}

	public void OnAcceptReenter(AcceptReenterMessage message)
	{
	}

	public override void OnAdditiveSceneChanged(bool isActiveScene)
	{
	}

	public bool ShowPvpDormantPanel(int score = 0, DateTime startedAt = default(DateTime))
	{
		return false;
	}

	public void OnClickUnitBundlePackage(int index)
	{
	}

	public void DoBGMFadeOut(float targetVolume = 0.5f)
	{
	}

	public void DoBGMFadeIn()
	{
	}
}

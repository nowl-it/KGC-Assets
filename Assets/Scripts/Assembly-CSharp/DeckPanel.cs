using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class DeckPanel : BaseLobbyPanel, IDraggableDeck
{
	public enum SortCondition
	{
		ByName = 0,
		ByID = 1,
		ByLevel = 2,
		ByRegion = 3,
		ByRole = 4,
		Count = 5
	}

	private enum ArtifactSortCondition
	{
		ByArtifactFromType = 0,
		ByArtifactLevel = 1,
		ByName = 2,
		ByDate = 3,
		Count = 4
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CEquipArtifact_003Ed__146 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactModel artifact;

		public DeckPanel _003C_003E4__this;

		public int idx;

		private List<EquippedArtifactData> _003CoriginData_003E5__2;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CSaveDeck_003Ed__124 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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

	public static DeckPanel Instance;

	public static int artifactCountPerPage;

	[ComponentConnect]
	public CardInfoPanel cardInfoPanel;

	[ComponentConnect]
	public Button sortingButton;

	public Button sortDescButton;

	public Text sortDescButtonIcon;

	[ComponentConnect]
	public Text sortButtonText;

	public Button artifactSortingButton;

	public Button artifactSortDescButton;

	public Text artifactSortDescButtonIcon;

	public Text artifactSortButtonText;

	[ComponentConnect]
	public CatalystBoxPanel catalystBoxPanel;

	[ComponentConnect]
	public ArtifactInfoPanel artifactInfoPanel;

	[ComponentConnect]
	public CraftPanel craftPanel;

	[SerializeField]
	private ImageTextPair _craftLevelLockObj;

	[ComponentConnect]
	public GameObject equipModePanel;

	[ComponentConnect]
	public GameObject equippedArtifacts;

	[ComponentConnect]
	public GameObject equippedArtifactsPreview;

	public Button artifactBox;

	[SerializeField]
	private ConditionalImage _artifactBoxCond;

	[SerializeField]
	private ImageTextPair _artifactLevelLockObj;

	[SerializeField]
	private GameObject artifactReqLevel;

	[ComponentConnect]
	public BuildingPanel buildingPanel;

	[ComponentConnect]
	public GameObject altarBox;

	public ConditionalGroup openCraftConditional;

	[Space(20f)]
	public DeckSlotToggle deckSlotToggle;

	public LayoutFitter deckSlotLayoutFitter;

	public Border deckSlotBorder;

	private List<DeckSlotToggle> _deckSlotToggles;

	[SerializeField]
	private DeckCombatPower _combatPower;

	[Space(20f)]
	public GameObject unitExpItemObj;

	public Text unitExpItemCount;

	public GameObject unitExpInfo;

	public GameObject unitSoulItemObj;

	public Text unitSoulItemCount;

	public GameObject unitSoulInfo;

	public GameObject dustItemObj;

	public Text dustItemCount;

	public GameObject dustInfo;

	public GameObject playerCurrencyObject;

	public Button toggleSoulButton;

	public SortCondition curSort;

	private DraggableUnitCard _dragging;

	public bool curSortDesc;

	private bool _showSoul;

	[ComponentConnect]
	[Space(20f)]
	public Text heroCountText;

	[ComponentConnect]
	public Text artifactCountText;

	[ComponentConnect]
	public RectTransform deckLayout;

	[ComponentConnect("CardsLayout", true)]
	public RectTransform cardsLayoutTransform;

	[ComponentConnect]
	public Text unitPageText;

	[ComponentConnect]
	public Text artifactPageText;

	[ComponentConnect]
	public RectTransform artifactsLayout;

	public GameObject artifactTabBG;

	[ComponentConnect]
	public Button pageLeftButton;

	[ComponentConnect]
	public Button pageRightButton;

	[ComponentConnect]
	public GameObject rightPageNewObject;

	[ComponentConnect]
	public Button artifactTab;

	public UnitCard[] currentDeck;

	public GameObject unitCardPrefab;

	public GameObject artifactCardPrefab;

	public DraggableArtifactCard[] equippedArtifactCards;

	public DraggableArtifactCard[] previewEquippedArtifactCards;

	public Text[] artifactLevelLimitTexts;

	public Text[] previewArtifactLevelLimitTexts;

	public DraggableArtifactCard equipModeArtifactCard;

	public BarrackAltarBox barrackAltarBox;

	public List<CardData> cardDatas;

	public List<DraggableUnitCard> unitCards;

	private UnitCard _focusedCard;

	public List<DraggableArtifactCard> artifactCards;

	private int _artifactCount;

	private DraggableArtifactCard _currentDraggingArtifact;

	private ArtifactSortCondition _curArtifactSort;

	private bool _curArtifactSortDesc;

	public Button _artifactTabInfoButton;

	public GameObject heroTabObj;

	public GameObject artifactTabObj;

	private int _currentUnitPage;

	private int _maxUnitPage;

	private int _currentArtifactPage;

	private int _maxArtifactPage;

	private bool _reloadedArtifactPages;

	public Func<ArtifactModel, bool> artifactFilter;

	private ArtifactCraftPanel _artifactCraftPanel => null;

	public bool showSoul => false;

	private bool _artifactTabActive => false;

	public int currentUnitPage => 0;

	public int maxUnitPage => 0;

	public bool reloadedArtifactPages => false;

	public void AddToggleListner(DeckSlotToggle toggle)
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}

	public void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void Clear()
	{
	}

	private void ReloadSortButton()
	{
	}

	public static void SortCards(List<CardData> cards)
	{
	}

	public void Reload()
	{
	}

	private void ReloadItemCountUI()
	{
	}

	private void ReloadDeck()
	{
	}

	public void ReloadDeckCombatPower()
	{
	}

	private void AddCard(CardData cardData, bool ownCard)
	{
	}

	public override void OnPanelEnabled()
	{
	}

	public override void OnPanelDisabled()
	{
	}

	public void SetDraggingCard(DraggableUnitCard card)
	{
	}

	private void OnClickOwnCard(UnitCard card)
	{
	}

	private void OnClickDeckCard(UnitCard card)
	{
	}

	private void ShowCardInfo(UnitCard card)
	{
	}

	public CardData FindCardByID(int id)
	{
		return null;
	}

	public void EquipCard(int idx, UnitCard card)
	{
	}

	private void AddToDeck2(int idx, int unitId, bool reload = true)
	{
	}

	public void UnEquipCard(UnitCard card)
	{
	}

	public void SwapDeckCard(UnitCard card1, UnitCard card2)
	{
	}

	private void RemoveFromDeck2(int idx, bool reload = true)
	{
	}

	[AsyncStateMachine(typeof(_003CSaveDeck_003Ed__124))]
	public void SaveDeck()
	{
	}

	public RectTransform GetDeckLayout()
	{
		return null;
	}

	public int GetIndexFromCurrentDeck(UnitCard card)
	{
		return 0;
	}

	public UnitCard FindCardFromCurrentDeck(Func<UnitCard, bool> func)
	{
		return null;
	}

	public void OnClickChangeDeckSlotPage()
	{
	}

	public void ReloadAllToggles()
	{
	}

	public void OnToggle(int idx, DeckSlotToggle from)
	{
	}

	public void SetAllToggleInteractable(bool set)
	{
	}

	public void SetSortDesc()
	{
	}

	public void OnSortChange()
	{
	}

	public void ReloadPrefab(int unitId)
	{
	}

	public void OnClickUnitPageMove(bool right)
	{
	}

	public void OnClickUnitPageMove(bool right, int count)
	{
	}

	public void ReloadUnitPage(bool clickRightPage = false)
	{
	}

	public void OnClickArtifactPageMove(bool right)
	{
	}

	public void ReloadArtifactPage()
	{
	}

	private void ClearArtifacts()
	{
	}

	public void ReloadArtifacts()
	{
	}

	public void ReloadArtifacts(bool maintainPage, bool forceReload = false)
	{
	}

	private DraggableArtifactCard AddArtifact(ArtifactModel artifact)
	{
		return null;
	}

	private DraggableArtifactCard AddArtifacts(List<ArtifactModel> artifacts)
	{
		return null;
	}

	public void SetDraggingArtifact(DraggableArtifactCard card)
	{
	}

	[AsyncStateMachine(typeof(_003CEquipArtifact_003Ed__146))]
	public void EquipArtifact(int idx, ArtifactModel artifact)
	{
	}

	public void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public void ShowNextArtifact(DraggableArtifactCard artifactCard, bool next)
	{
	}

	public void OnClickOpenCraft()
	{
	}

	public void OnCloseCraftPanel()
	{
	}

	public void SetArtifactDraggable(bool v)
	{
	}

	public DraggableArtifactCard GetArtifactCard(int id)
	{
		return null;
	}

	public void EquipMode(ArtifactModel artifact)
	{
	}

	public void ReloadDeckArtifactOptions()
	{
	}

	public void ToggleArtifactTabObjActive()
	{
	}

	public void ShowArtifactTabObj()
	{
	}

	public void CloseArtifactTabObj()
	{
	}

	public void OnClickArtifactLevelLocked(int idx)
	{
	}

	public void OnClickAltar()
	{
	}

	public DraggableArtifactCard[] GetEquippedArtifactCards()
	{
		return null;
	}

	public int[] GetCurrentDeck()
	{
		return null;
	}

	public int GetArtifactOptionSum(int unitPos, string type)
	{
		return 0;
	}

	public void OnClickUnitExpInfo()
	{
	}

	public void OnClickUnitSoulInfo()
	{
	}

	public void OnClickDustInfo()
	{
	}

	public void OnClickToggleSoul()
	{
	}

	public void OnClickInventory()
	{
	}

	public void SetFullPopupDeckUI(bool set)
	{
	}

	public void ShowStatInfo()
	{
	}
}

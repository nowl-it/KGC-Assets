using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public abstract class DeckSettingPanel : PopupPanel, IDraggableDeck
{
	public enum CloseState
	{
		Default = -1,
		Wait = 0,
		Close = 1,
		Cancel = 2
	}

	public class BarrackInfo
	{
		public class DeckSettingCardInfo
		{
			public int unitId;

			public int level;

			public int skin;

			public int potentialTier;

			public bool isLevelSyncApplied;

			public bool supported;

			public int accountId;

			public string accountName;

			public TreasureModel treasure;

			public List<AccessoryModel> accessories;

			public DeckSettingCardInfo()
			{
			}

			public DeckSettingCardInfo(CardData cardData)
			{
			}
		}

		public DeckSettingCardInfo[] cards;

		public int[] buildings;

		public List<ArtifactModel> artifacts;

		public int[] potentials;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickSelectPreset_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DeckSettingPanel _003C_003E4__this;

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
	private struct _003CWaitForClose_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public DeckSettingPanel _003C_003E4__this;

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

	public static DeckSettingPanel currentActiveDeckSettingPanel;

	[SerializeField]
	private Image[] _deckBgObjects;

	[SerializeField]
	private Image[] _layoutBgObjects;

	[ComponentConnect]
	public RectTransform deckLayout;

	[ComponentConnect("CardsLayout", true)]
	public RectTransform cardsLayoutTransform;

	[ComponentConnect]
	public RectTransform artifactsLayout;

	[ComponentConnect]
	public TabManager tabManager;

	[ComponentConnect]
	public GameObject heroTabObject;

	[ComponentConnect]
	public GameObject artifactTabObject;

	[ComponentConnect]
	public GameObject heroTabOver;

	[ComponentConnect]
	public GameObject supporterTabOver;

	[ComponentConnect]
	public Text unitPageText;

	[ComponentConnect]
	public Text artifactPageText;

	[ComponentConnect]
	public Text artifactCountText;

	[ComponentConnect]
	public Button pageLeftButton;

	[ComponentConnect]
	public Button pageRightButton;

	public DraggableUnitCard[] currentDeck;

	public GameObject unitCardPrefab;

	public GameObject artifactCardPrefab;

	public DraggableArtifactCard[] equippedArtifactCards;

	public GameObject[] artifactLevelLimitObjects;

	public TerritoryStatBuffDisplayer territoryStatBuffDisplayer;

	public AltarPreviewItem[] altarPreviewItems;

	public GameObject noSupporterObj;

	private DraggableUnitCard _dragging;

	private List<DraggableUnitCard> _unitCards;

	private List<DraggableArtifactCard> _artifactCards;

	private DraggableArtifactCard _currentDraggingArtifact;

	private int _currentUnitPage;

	private int _maxUnitPage;

	private int _currentSupportUnitPage;

	private int _maxSupportUnitPage;

	private int _currentArtifactPage;

	private int _maxArtifactPage;

	private int _currentTabIdx;

	private const int MAX_PAGE_UNIT_COUNT = 18;

	private const int MAX_PAGE_ARTIFACT_COUNT = 24;

	public CloseState _closeState;

	public bool clearOnShow;

	private int _maxArtifactCounts;

	protected bool doNotShowAlert;

	protected bool waitForClose;

	public void Awake()
	{
	}

	public override void Show()
	{
	}

	private void OnToggleTab(int idx)
	{
	}

	protected virtual void Reload()
	{
	}

	public void ReloadCards()
	{
	}

	public void ReloadSupporters()
	{
	}

	private void ReloadDeck()
	{
	}

	private void ShowCardInfo(UnitCard card)
	{
	}

	private void AddCard(CardData cardData, bool ownCard, int index)
	{
	}

	public void EquipCard(int idx, UnitCard card)
	{
	}

	public void UnEquipCard(UnitCard card)
	{
	}

	public void SwapDeckCard(UnitCard card1, UnitCard card2)
	{
	}

	private void RemoveFromDeck(int idx, bool reload = true)
	{
	}

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

	public int GetIndexFromCurrentLayout(UnitCard card)
	{
		return 0;
	}

	public int GetIndexFromCurrentDeck(int unitId)
	{
		return 0;
	}

	public UnitCard FindCardFromCurrentDeck(Func<UnitCard, bool> func)
	{
		return null;
	}

	public void ReloadDeckArtifactOptions()
	{
	}

	public void OnClickUnitPageMove(bool right)
	{
	}

	public void ReloadUnitPage()
	{
	}

	public void OnClickArtifactPageMove(bool right)
	{
	}

	public void ReloadArtifactPage()
	{
	}

	public void ReloadArtifacts(int pageAfterReload = 0)
	{
	}

	private DraggableArtifactCard AddArtifact(ArtifactModel artifact, int index)
	{
		return null;
	}

	private void SetDraggableArtifactCard(ArtifactModel artifact, BarrackInfo barrack, int index)
	{
	}

	private void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public void SetDraggingArtifact(DraggableArtifactCard card)
	{
	}

	public void EquipArtifact(int idx, ArtifactModel artifact)
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}

	public void SetDraggingCard(DraggableUnitCard card)
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

	private void ReloadAltar()
	{
	}

	public void SetCardPotential(int unitId, int potential)
	{
	}

	public void RefreshPotentialIcon(int unitId)
	{
	}

	public void OnClickAltar()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickSelectPreset_003Ed__80))]
	public void OnClickSelectPreset()
	{
	}

	public void OnClickClear()
	{
	}

	private void Clear()
	{
	}

	public override bool Close()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CWaitForClose_003Ed__86))]
	public UniTask<bool> WaitForClose()
	{
		return default(UniTask<bool>);
	}

	protected virtual int SortCard(CardData a, CardData b)
	{
		return 0;
	}

	protected virtual bool FilterCard(CardData cardData)
	{
		return false;
	}

	protected abstract BarrackInfo GetBarrack();

	protected abstract void SetBarrack(BarrackInfo barrack);

	protected virtual (bool, string) GetStatusBoxInfo(CardData card)
	{
		return default((bool, string));
	}

	public virtual bool CanEquipCard(int idx, UnitCard card)
	{
		return false;
	}

	public Image GetDeckBgObject(int index)
	{
		return null;
	}

	public Image GetLayoutBgObject(int index)
	{
		return null;
	}

	public void OnClickArtifactLevelLocked(int idx)
	{
	}
}

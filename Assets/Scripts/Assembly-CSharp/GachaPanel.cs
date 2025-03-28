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

public class GachaPanel : PopupPanel
{
	private enum PanelState
	{
		None = 0,
		Dismantle = 1
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public List<int> prevPlayerPackages;

		public GachaPanel _003C_003E4__this;

		public List<ShopItemModel> newPlayerPackages;

		public bool showNewUnitPopup;

		internal bool _003CShow_003Eb__4(ShopItemModel x)
		{
			return false;
		}

		internal void _003CShow_003Eb__5()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDismantleImpl_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GachaPanel _003C_003E4__this;

		private List<ArtifactModel> _003Clst_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private int _003CprevLoadingPopupIdx_003E5__3;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickDismantleState_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GachaPanel _003C_003E4__this;

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
	private struct _003CShow_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GachaPanel _003C_003E4__this;

		public BuyResponseModel ret;

		public ResourceGacha gacha;

		public bool skipBoxOpen;

		public GachaResultCollection datas;

		public Action onComplete;

		private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

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

	[ComponentConnect]
	public GachaNewUnitPanel newUnitPanel;

	[ComponentConnect]
	public GachaCard unitExpCard;

	[ComponentConnect]
	public GachaCard goldCard;

	[ComponentConnect]
	public GachaCard cashCard;

	[ComponentConnect]
	public GachaCard inventoryItemCard;

	[ComponentConnect]
	public GachaCard artifactPieceCard;

	[ComponentConnect]
	public GachaCard artifactCard;

	[ComponentConnect]
	public GachaCard expBookCard;

	[ComponentConnect]
	public GachaCard unitSoulCard;

	[ComponentConnect]
	public GachaCard unitSoulItemCard;

	[ComponentConnect]
	public Text remainCountText;

	[ComponentConnect]
	public GameObject remainCountBox;

	[ComponentConnect]
	public GameObject resultPanel;

	[GetComponent]
	public ConditionalGroup newCondGroup;

	[ComponentConnect]
	public GridLayoutGroup resultLayout;

	[ComponentConnect]
	public LayoutFitter resultLayoutFitter;

	public Button SkipAllButton;

	public Animator cardEffect;

	public Animator UnitSoulEffect;

	public Animator newCardEffect;

	public Animator artifactEffect;

	public Animator[] gachaBoxes;

	public List<GachaResultItem> resultItems;

	public GachaResultItem resultItemObj;

	public GameObject gachaResultFoldButton;

	public ScrollRect gachaResultScrollRect;

	public ConditionalGroup dismantleButton;

	public Button dismantleButtonComponent;

	public Text dismantleButtonText;

	public Image dismantleIcon;

	public ConditionalGroup closeButton;

	public Button allSelectButton;

	public GameObject allSelectedObj;

	[NonSerialized]
	public GachaResultItem lastSelectedItem;

	private List<GachaResult> _datas;

	private List<GachaResult> _remains;

	private bool _boxOpening;

	private bool _boxOpened;

	private IGachaResult _openedResultItem;

	private Action _onComplete;

	private ResourceGacha _gacha;

	private bool _showOnlyNewUnit;

	private List<int> newUnitsIds;

	private Action _showPopupChains;

	private PanelState _panelState;

	private BuyResponseModel _ret;

	private bool _canClose;

	private bool _duringDismantle;

	public Animator curBox => null;

	public bool dismantleAllSelected => false;

	[Obsolete]
	public override void Show()
	{
	}

	[AsyncStateMachine(typeof(_003CShow_003Ed__53))]
	public void Show(ResourceGacha gacha, GachaResultCollection datas, Action onComplete = null, bool skipBoxOpen = false, BuyResponseModel ret = null)
	{
	}

	public void Hide()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public void OnClick()
	{
	}

	private void BoxOpen()
	{
	}

	private bool SkipBoxOpen()
	{
		return false;
	}

	private bool SkipCardOpen()
	{
		return false;
	}

	private void ShowCardEffect(Animator effect, bool isCard)
	{
	}

	private void ShowNextItem()
	{
	}

	private void ShowResult()
	{
	}

	public void UnFoldResult()
	{
	}

	public void ShowOnlyNewUnit(int unitId, int soulCount = 0, Action onComplete = null, bool showNewUnitPopup = true, bool showAlchemyGachaItem = true)
	{
	}

	public void OnClickSkipAll()
	{
	}

	private void ShowPopupChain(List<ShopItemModel> shopItemModels, bool showNewUnitPopup)
	{
	}

	private void ShowNewUnitPopup()
	{
	}

	public void OnClickResultBackground()
	{
	}

	public void OnClickButton(int index)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDismantleState_003Ed__70))]
	public void OnClickDismantleState()
	{
	}

	public void OnClickNoneState()
	{
	}

	public void ReloadButtonsState()
	{
	}

	private void ReloadState()
	{
	}

	public void OnClickDismantleAllSelectButton()
	{
	}

	[AsyncStateMachine(typeof(_003CDismantleImpl_003Ed__76))]
	private UniTaskVoid DismantleImpl()
	{
		return default(UniTaskVoid);
	}

	private int GetDismantleDustCount()
	{
		return 0;
	}

	public static void AdjustAlchemyGachaItem(List<GachaResult> gachas)
	{
	}

	public static void RevertAlchemyGachaItemChanges(List<GachaResult> gachas)
	{
	}
}

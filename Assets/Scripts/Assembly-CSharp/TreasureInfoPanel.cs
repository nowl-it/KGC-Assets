using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TreasureInfoPanel : PopupPanel
{
	[Serializable]
	public class ReleaseEquipPanel
	{
		public GameObject gameObject;

		public Text releaseEquipCooltimeText;
	}

	public enum PanelState
	{
		None = 0,
		Default = 1,
		Upgrade = 2,
		OwnedTreasures = 3
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDismantle_003Ed__102 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureInfoPanel _003C_003E4__this;

		private List<InventoryItem> _003CrewardInventories_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickEquip_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureInfoPanel _003C_003E4__this;

		public int treasureID;

		public int unitID;

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
	private struct _003COnClickReleaseEquip_003Ed__98 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureInfoPanel _003C_003E4__this;

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
	private struct _003COnClickState_003Ed__108 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureInfoPanel _003C_003E4__this;

		public int state;

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
	private struct _003COnClickUpgrade_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureInfoPanel _003C_003E4__this;

		public List<InventoryItem> usingMaterials;

		private int _003CprevLevel_003E5__2;

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
	private struct _003CTestOnClickCoolTimeReset_003Ed__118 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureInfoPanel _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003CUpdateReleaseEquipPanelCoolTimeText_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreasureInfoPanel _003C_003E4__this;

		private WaitForSeconds _003Csecond_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateReleaseEquipPanelCoolTimeText_003Ed__97(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpdateUnlockButtonRemainTime_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreasureInfoPanel _003C_003E4__this;

		private WaitForSeconds _003Csecond_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateUnlockButtonRemainTime_003Ed__84(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private TextFitter _nameTextFitter;

	[SerializeField]
	private Text _subNameText;

	[SerializeField]
	private GameObject _roleObj;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private TreasureCardItem _treasureCardItem;

	[SerializeField]
	private TreasureCardItem _nextTreasureCardItem;

	[SerializeField]
	private ConditionalGroup _stateCond;

	[SerializeField]
	private HqTreasureIllustPopup _hqTreasureIllustPopup;

	[SerializeField]
	private GameObject[] _objectsToDeactivateWhenNotOwned;

	[SerializeField]
	private RectTransform _upperObjects;

	[SerializeField]
	private GameObject _showIllustButton;

	[SerializeField]
	private TabManager _stateTabManager;

	[Space(20f)]
	[SerializeField]
	private GameObject _informationGroupMainObj;

	[SerializeField]
	private TreasureSkillUI _treasureSkillUI;

	[SerializeField]
	private Button _overcomeAreaButton;

	[SerializeField]
	private RectTransform _overcomeDescTextsRoot;

	[SerializeField]
	private List<Image> _treasureOvercomeIcons;

	[SerializeField]
	private GameObject _treasureOvercomePreviewObj;

	[SerializeField]
	private ImageTextPair _overcomeDescTextPrefab;

	private List<ImageTextPair> _treasureOvercomeDescTexts;

	[SerializeField]
	private Button _prevButton;

	[SerializeField]
	private Button _nextButton;

	[SerializeField]
	private ClickOutsideClose _tooltip;

	[SerializeField]
	private TextFitter _informationTooltipTextFitter;

	[SerializeField]
	private Border _informationTooltipBorder;

	[SerializeField]
	private ClickOutsideClose _skillTooltip;

	[SerializeField]
	private TextFitter _skillTooltipTextFitter;

	[SerializeField]
	private Border _skillTooltipBorder;

	[SerializeField]
	[Space(15f)]
	private ConditionalGroup _levelupButton;

	[SerializeField]
	private ConditionalImage _overcomeButton;

	[SerializeField]
	[Space(15f)]
	private ConditionalGroup _equipButton;

	[SerializeField]
	private ConditionalGroup _changeButton;

	[SerializeField]
	private Text _equipButtonText;

	[SerializeField]
	private Price _unlockButtonPrice;

	[SerializeField]
	private Text _unlockButtonRemainTimeText;

	[SerializeField]
	private Image _lockButtonRoleIcon;

	[SerializeField]
	private Text _lockButtonRoleText;

	[Space(15f)]
	[SerializeField]
	private Button _utilizationButton;

	[SerializeField]
	[Space(20f)]
	private GameObject _upgradableGroupMainObj;

	[SerializeField]
	private TreasureSkillUI _upgradeGroupTreasureSkillUI;

	[SerializeField]
	private UpgradableUI _upgradableUI;

	[SerializeField]
	private Image _upgradeSkillDescWhiteFlash;

	[SerializeField]
	[Space(15f)]
	private GameObject _ownedTreasuresMainObj;

	[SerializeField]
	private UIGridView _ownedTreasuresView;

	[SerializeField]
	[Space(20f)]
	private ReleaseEquipPanel _releaseEquipPanel;

	[SerializeField]
	[Space(20f)]
	private RewardPopup _dismantleConfirmPopup;

	private TreasureOvercomePanel _treasureOvercomePanel;

	private TreasureModel _treasure;

	private string _showFrom;

	private int _unitId;

	private bool _owned;

	private List<Tween> _upgradeEffectTweens;

	private Sequence _upgradeSkillDescWhiteFlashSequence;

	private Sequence _moveToOtherTreasureSequence;

	private PanelState _curState;

	private bool _requestProcessing;

	private Action _closeCallback;

	private Action _beforePreviewReloadAction;

	private TreasureModel _clonedTreasure;

	private Coroutine _unlockButtonRemainTimeCoroutine;

	private Coroutine _updateCoolTimeTextCoroutine;

	private bool _duringDismantle;

	private ulong? _dismantleButtonTimer;

	public Button overcomeAreaButton => null;

	public Button overcomeButton => null;

	public TreasureOvercomePanel treasureOvercomePanel => null;

	private ResourceTreasure _resTreasure => null;

	public string showFrom => null;

	private void ReloadCurState()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void Show(TreasureModel treasure, string showFrom, bool owned, int unitId = -1, Action closeCallback = null)
	{
	}

	private void ReloadObjectActiveByOwnedState()
	{
	}

	public void ReloadByState(PanelState panelState)
	{
	}

	private void ReloadDefaultState()
	{
	}

	public void ShowHqIllustPopup()
	{
	}

	public static void SetOvercomeEffectUI(TreasureModel treasure, List<Image> overcomeIcons, List<ImageTextPair> descTexts, ImageTextPair descTextPrefab, RectTransform descTextsRoot, int start = -1, int end = -1, bool showName = true, bool showDisable = false, bool starSetEndValue = false)
	{
	}

	private void SetButtonsState()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateUnlockButtonRemainTime_003Ed__84))]
	private IEnumerator UpdateUnlockButtonRemainTime()
	{
		return null;
	}

	public void OnClickDefaultState()
	{
	}

	public void OnclickUpgradeState()
	{
	}

	public void OnClickOvercome()
	{
	}

	private void ReloadUpgradeState()
	{
	}

	private void ReloadOwnedTreasuresState()
	{
	}

	private void InitOwnedTreasureItem(TreasureUIItem uiItem, TreasureModel treasure)
	{
	}

	private void OnUpgradeMaterialChange()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUpgrade_003Ed__92))]
	private void OnClickUpgrade(List<InventoryItem> usingMaterials)
	{
	}

	private void ShowUpgradeEffects(int prevLevel, int curLevel)
	{
	}

	private void ClearUpgradeEffectTweens()
	{
	}

	public void OnClickReleaseEquipPanel()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateReleaseEquipPanelCoolTimeText_003Ed__97))]
	private IEnumerator UpdateReleaseEquipPanelCoolTimeText()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickReleaseEquip_003Ed__98))]
	public void OnClickReleaseEquip()
	{
	}

	public void OnClickReleaseEquipPanelClose()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDismantle_003Ed__102))]
	public void OnClickDismantle()
	{
	}

	public void OnclickNextOrPrevTreasure(int idx)
	{
	}

	public void LeftButtonAction()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickEquip_003Ed__105))]
	public void OnClickEquip(int unitID = -1, int treasureID = -1)
	{
	}

	public void RightButtonAction()
	{
	}

	public void OnClickChange()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickState_003Ed__108))]
	public void OnClickState(int state)
	{
	}

	public void ActiveOffUtilizationButton()
	{
	}

	public void SetUtilizationButton(bool active, UnityAction action, string text)
	{
	}

	public void SetPreviewObjActive(bool active, Action beforePreviewReloadAction = null)
	{
	}

	private void HandleSkillPreviewChanged(TreasureModel treasure)
	{
	}

	private void HandleOvercomePreviewChanged()
	{
	}

	public void OnClickOvercomePreview(int idx)
	{
	}

	public void SetStateTabManagerActive(bool active)
	{
	}

	public override void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CTestOnClickCoolTimeReset_003Ed__118))]
	public void TestOnClickCoolTimeReset()
	{
	}
}

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryInfoPanel : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDismantle_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AccessoryInfoPanel _003C_003E4__this;

		private List<InventoryItem> _003CrewardItems_003E5__2;

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
	private struct _003COnClickReleaseEquip_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AccessoryInfoPanel _003C_003E4__this;

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
	private struct _003COnClickState_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AccessoryInfoPanel _003C_003E4__this;

		public int state;

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
	private struct _003CTestSetAccessoryCoolTime_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AccessoryInfoPanel _003C_003E4__this;

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

	[SerializeField]
	private Image _bgImage;

	[SerializeField]
	private GameObject _informationObj;

	[SerializeField]
	private Image _accessoryMainInformationBg;

	[SerializeField]
	private AccessoryUIItem _accessoryItem;

	[SerializeField]
	private Text _rarityText;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Button _closeButton;

	[SerializeField]
	private UIFitter[] _accessoryInfoUIFitters;

	[SerializeField]
	private Image _mainUIFrame;

	[Space(20f)]
	[SerializeField]
	private AccessoryStatUI _mainStatUI;

	[SerializeField]
	private GameObject _mainStatUpgradeTextObject;

	[SerializeField]
	private Text _mainStatUpgradeText;

	[SerializeField]
	private Text _mainStatUpgradePercentText;

	[SerializeField]
	private AccessoryStatUI _accessorySubStatUIPrefab;

	[SerializeField]
	private RectTransform _accessorySubStatUIsRoot;

	private List<AccessoryStatUI> _subStatUIs;

	[SerializeField]
	private Text _scoreText;

	[Space(20f)]
	[SerializeField]
	private AccessorySynergyToolTip _synergyToolTip;

	[Space(20f)]
	[SerializeField]
	private GameObject _characterInfoObj;

	[SerializeField]
	private DraggableUnitCard _unitCard;

	[SerializeField]
	private Text _noUnitText;

	[SerializeField]
	private Image _unitIllust;

	[SerializeField]
	private Image[] _unitIllustGradation;

	[Space(20f)]
	[SerializeField]
	private Button _cardInfoButton;

	[SerializeField]
	private ConditionalGroup _stateCond;

	[SerializeField]
	private GameObject _mainActionButtonsGroup;

	[SerializeField]
	private ConditionalImage _upgradeButton;

	[SerializeField]
	private Button _dismantleButton;

	[SerializeField]
	private Button _usedInDeckButton;

	[SerializeField]
	private Text _upgradeButtonText;

	[SerializeField]
	private ConditionalGroup _buttonsCond;

	[Space(20f)]
	[SerializeField]
	private AccessoryCraftPanel _accessoryCraftPanel;

	[Space(20f)]
	[SerializeField]
	private RewardPopup _dismantleConfirmPopup;

	[Space(20f)]
	[SerializeField]
	private DevAccessoryStatPanel _devAccessoryStatPanel;

	private AccessoryModel _accessory;

	private bool _isShort;

	private CardData _cardData;

	private bool _owned;

	private bool _requestProcessing;

	private bool _duringDismantle;

	private ulong? _dismantleButtonTimer;

	public Button upgradeButton => null;

	public AccessoryCraftPanel accessoryCraftPanel => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(AccessoryModel accessory, bool isShort, bool owned, CardData cardData)
	{
	}

	private void Update()
	{
	}

	private void Reload()
	{
	}

	public static void SetStatUI(AccessoryModel accessory, AccessoryStatUI mainStatUI, List<AccessoryStatUI> subStatUIs, AccessoryStatUI subStatUIPrefab, RectTransform subStatUIsRoot)
	{
	}

	private void UpdateUpgradeMainSlotText()
	{
	}

	public void SetSynergies(List<AccessoryModel> equippedAccessories)
	{
	}

	public void OnClickCardInfo()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickState_003Ed__52))]
	public void OnClickState(int state)
	{
	}

	public void OnClickUpgrade()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDismantle_003Ed__56))]
	public void OnClickDismantle()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReleaseEquip_003Ed__57))]
	public void OnClickReleaseEquip()
	{
	}

	public void OnClickChange()
	{
	}

	public override bool Close()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CTestSetAccessoryCoolTime_003Ed__60))]
	public void TestSetAccessoryCoolTime()
	{
	}

	public void TestAccessoryStat()
	{
	}
}

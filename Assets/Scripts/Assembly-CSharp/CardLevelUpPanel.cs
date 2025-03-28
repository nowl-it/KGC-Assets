using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class CardLevelUpPanel : MonoBehaviour, IClosable
{
	[Serializable]
	private struct UnitInfo
	{
		public StatType hpStat;

		public StatType atkStat;

		public StatType matkStat;

		public PotentialButton[] potentialButtons;

		public GameObject gameObject;
	}

	[Serializable]
	private struct SkillInfo
	{
		public Text skillLevelText;

		public GameObject partition;

		public Text skillDescText;

		public GameObject newImage;

		public GameObject gameObject;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public bool processed;

		internal void _003COnClickUseCandy_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickLevelUp_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardLevelUpPanel _003C_003E4__this;

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
	private struct _003COnClickShopButton_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardLevelUpPanel _003C_003E4__this;

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
	private struct _003COnClickUseCandy_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int candyId;

		public CardLevelUpPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass84_0 _003C_003E8__1;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<Awesomepiece.Model.CardWithCandiesResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickUseUnitExpItem_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardLevelUpPanel _003C_003E4__this;

		public int count;

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
	private struct _003COnClickUseUnitSoulAsExp_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardLevelUpPanel _003C_003E4__this;

		public int count;

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
	private struct _003COnClickUseUnitSoulItem_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardLevelUpPanel _003C_003E4__this;

		public int count;

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
	private struct _003COnClickUseUnitSoulItemAsExp_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardLevelUpPanel _003C_003E4__this;

		public int count;

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
	private SimpleCurrencyItem _goldCurrencyItem;

	[SerializeField]
	private RectTransform _unitPrefabRoot;

	[SerializeField]
	private Image[] _unitLevelBox;

	[SerializeField]
	private GameObject[] _unitLevelFrame;

	[SerializeField]
	private Text _unitLevelText;

	[SerializeField]
	private Gauge _expGauge;

	[SerializeField]
	private Gauge _expGaugeSmall;

	[SerializeField]
	private Gauge _soulGaugeSmall;

	[SerializeField]
	private UnitInfo _skillUnitInfo;

	[SerializeField]
	private UnitInfo _noneSkillUnitInfo;

	[SerializeField]
	private UnitInfo _potentialUnitInfo;

	[SerializeField]
	[Space(20f)]
	private GameObject potentialTooltip;

	[SerializeField]
	private Text potentialTooltipText;

	private UnitInfo _unitInfo;

	[SerializeField]
	private SkillInfo _skillInfo;

	[Space(20f)]
	[SerializeField]
	private GameObject _itemPrefab;

	[SerializeField]
	private RectTransform _itemsRoot;

	[SerializeField]
	private GameObject _itemDescBoard;

	[SerializeField]
	private Image _itemIconImage;

	[SerializeField]
	private Text _itemUseAmountText;

	[SerializeField]
	private Text _expEarnAmountText;

	[SerializeField]
	private Text _itemCountText;

	[SerializeField]
	private GameObject _useSoulAsExpButton;

	[SerializeField]
	private Text _itemDescText;

	[SerializeField]
	private GameObject _upgradeButton;

	[SerializeField]
	private Text _levelUpButtonText;

	[SerializeField]
	private Price _levelUpPrice;

	[SerializeField]
	private Text _levelUpButtonOtherText;

	[SerializeField]
	private ConditionalGroup _levelUpButtonConditionals;

	[SerializeField]
	private Text _shopButtonText;

	[SerializeField]
	private Button _shopButton;

	private CardData _cardData;

	private ResourceUnit _resUnit;

	private ResourceSkin _resSkin;

	private readonly List<CardLevelUpItemCell> _itemCells;

	private GameObject skinPrefab;

	private string _cachedSkinPrefab;

	private bool _isPotentialUpgrade;

	private int _goldCost;

	private int _expCost;

	private int _soulCost;

	private int _neededGold;

	private int _neededExp;

	private int _neededSoul;

	private int _selectedItemIndex;

	private bool _useSoulAsExp;

	private Action _onClickLevelUpButton;

	private bool _isLoading;

	public RectTransform levelUpItemsRoot => null;

	private StatType _hpStat => null;

	private StatType _atkStat => null;

	private StatType _matkStat => null;

	public GameObject itemDescBoard => null;

	public GameObject upgradeButton => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(CardData cardData)
	{
	}

	public CardLevelUpItemCell FindLevelUpItem(int inventoryItemId)
	{
		return null;
	}

	private void Reload(bool reloadExp = false, bool reloadSoup = false)
	{
	}

	public void ReloadCurrencies()
	{
	}

	private void OnCardExpCallbackInvoked()
	{
	}

	public void ReloadGauges(bool exp, bool soul)
	{
	}

	private void ReloadCosts()
	{
	}

	private void SettingOnClickLevelUp()
	{
	}

	private void OnClickItem(int idx, bool cancelWhenSameIdx = true)
	{
	}

	private bool CanUseItem(ResourceInventoryItem resItem)
	{
		return false;
	}

	private string GetItemLockedReason(ResourceInventoryItem resItem)
	{
		return null;
	}

	private bool NeedSoulToUpgrade()
	{
		return false;
	}

	public void OnClickConfirmButton()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickShopButton_003Ed__77))]
	public void OnClickShopButton()
	{
	}

	private bool IsCardMaxLv()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003COnClickLevelUp_003Ed__79))]
	private void OnClickLevelUp()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUseUnitExpItem_003Ed__80))]
	private void OnClickUseUnitExpItem(int count)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUseUnitSoulAsExp_003Ed__81))]
	private void OnClickUseUnitSoulAsExp(int count)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUseUnitSoulItem_003Ed__82))]
	private void OnClickUseUnitSoulItem(int count)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUseUnitSoulItemAsExp_003Ed__83))]
	private void OnClickUseUnitSoulItemAsExp(int count)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUseCandy_003Ed__84))]
	private void OnClickUseCandy(int candyId)
	{
	}

	private int GetItemCount(int inventoryItemId)
	{
		return 0;
	}

	public void OnClickUseSoulAsExpButton()
	{
	}

	public void OnClickPotentialButton(int potentialSlot)
	{
	}

	public void OnClickPotentialToolTip()
	{
	}

	public void SetLoading(bool set)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}

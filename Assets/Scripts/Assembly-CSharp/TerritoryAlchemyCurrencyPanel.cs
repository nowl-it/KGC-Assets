using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAlchemyCurrencyPanel : MonoBehaviour
{
	public enum AlchemyCurrencyType
	{
		Labor = 0,
		Dust = 1,
		AlchemyItem = 2,
		UnitExp = 3,
		UnitSoul = 4
	}

	public class AlchemyCurrencyData : IEquatable<AlchemyCurrencyData>, IComparable<AlchemyCurrencyData>
	{
		public AlchemyCurrencyType type;

		public int id;

		public IntReactiveProperty count;

		public bool IsSameType(AlchemyCurrencyData currencyData)
		{
			return false;
		}

		public AlchemyCurrencyData Copy()
		{
			return null;
		}

		public TerritoryAlchemyRequestModel.AlchemyCurrencyData ToSerializable()
		{
			return null;
		}

		public ResourceAlchemyExchangeRatio GetResourceAlchemyRatio()
		{
			return null;
		}

		public bool Equals(AlchemyCurrencyData other)
		{
			return false;
		}

		public int CompareTo(AlchemyCurrencyData other)
		{
			return 0;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickStartAlchemy_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryAlchemyCurrencyPanel _003C_003E4__this;

		private UniTask<TerritoryAlchemyResponseModel>.Awaiter _003C_003Eu__1;

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
	private TerritoryAlchemyRewardItem _rewardItem;

	[SerializeField]
	private ConditionalGroup _alchemyGaugeLevelCond;

	[SerializeField]
	private RectTransform _alchemyGaugeFill;

	[SerializeField]
	private Text _alchemyGaugeText;

	[SerializeField]
	private UIGridView _currencyItemsView;

	[SerializeField]
	private Button _alchemyButton;

	[SerializeField]
	private GameObject _autoSelectPanel;

	[SerializeField]
	private GameObject[] _itemContainsAutoSelectedObj;

	[SerializeField]
	private bool[] _itemContainsAutoSelect;

	private List<IDisposable> _binds;

	private int _ownItemCounter;

	private List<(int ownCount, AlchemyCurrencyData data)> _playerCurrencies;

	private TerritoryAlchemyPanel _parent;

	[NonSerialized]
	public TerritoryBuilding building;

	private ResourceTerritoryAlchemyItem _resAlchemyItem;

	private int _rewardIdx;

	private int _rewardVersion;

	private List<(int currencyIdx, bool currencyItem)> _playerCurrencyItemContainsExpanded;

	private static bool _processing;

	public int alchemyReqPoint => 0;

	public void Show(TerritoryAlchemyPanel parent, TerritoryBuilding building, ResourceTerritoryAlchemyItem resAlchemyItem, int rewardIdx, int rewardVersion)
	{
	}

	private void Reload()
	{
	}

	private void ReloadGauge()
	{
	}

	private void Clear()
	{
	}

	public void ReloadCurrencyItems()
	{
	}

	private void SetCurrencyItem(int index, GameObject go, bool isCurrencyItem)
	{
	}

	public void HandleItemExpand(AlchemyCurrencyData currencyData, bool expand)
	{
	}

	private void BuildPlayerCurrencies()
	{
	}

	public static void AddToCurrencyList(List<(int ownCount, AlchemyCurrencyData data)> playerCurrencies, bool forceContainsDefaultItems)
	{
	}

	public int CalculateGauge()
	{
		return 0;
	}

	private void OnDisable()
	{
	}

	public void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStartAlchemy_003Ed__35))]
	public void OnClickStartAlchemy()
	{
	}

	public void ToggleAutoSelectPanel()
	{
	}

	private void ReloadAutoSelectFilter()
	{
	}

	public void ToggleItemContainsAutoSelect(int index)
	{
	}

	public void OnClickAutoSelect()
	{
	}

	private void ClampCurrencyItemsAfterAutoSelect()
	{
	}

	private void ClampCurrencyItemAfterAutoSelect((int ownCount, AlchemyCurrencyData data) item)
	{
	}

	public void ItemAutoSelect((int ownCount, AlchemyCurrencyData data) find)
	{
	}

	public int ClampCurrencyAmount(float from, AlchemyCurrencyData currencyData, int ownCount)
	{
		return 0;
	}

	public int PointToAmount(float point, float ratio, int ownAmount, bool ceil = true)
	{
		return 0;
	}

	public int AmountToPoint(float amount, float ratio, bool ceil = true)
	{
		return 0;
	}

	public float ApplyUnit(float amount, int ownAmount, float ratio)
	{
		return 0f;
	}
}

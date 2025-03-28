using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAlchemyPanel_Old : TerritoryBuildingMenuBase
{
	public enum AlchemyCurrencyType
	{
		Labor = 0,
		Dust = 1,
		AlchemyItem = 2,
		UnitExp = 3,
		UnitSoul = 4
	}

	public class AlchemyCurrencyData
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
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public TerritoryAlchemyPanel_Old _003C_003E4__this;

		public bool effectEnd;

		public Action _003C_003E9__2;

		internal void _003COnClickStartAlchemy_003Eb__0()
		{
		}

		internal void _003COnClickStartAlchemy_003Eb__2()
		{
		}

		internal bool _003COnClickStartAlchemy_003Eb__1()
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickStartAlchemy_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryAlchemyPanel_Old _003C_003E4__this;

		private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

		private TerritoryAlchemyResponseModel _003Cret_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<TerritoryAlchemyResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask.Awaiter _003C_003Eu__3;

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

	[Space(20f)]
	[SerializeField]
	private List<Image> _gaugeImages;

	[SerializeField]
	private List<Image> _tempGaugeImages;

	[SerializeField]
	private Text _gaugeText;

	[SerializeField]
	private GameObject _rewardPanel;

	[SerializeField]
	private GameObject _cannotSelectObj;

	[SerializeField]
	private GameObject _alchemyRewardPrefab;

	[SerializeField]
	private GameObject _alchemyCurrencyPrefab;

	[SerializeField]
	private RectTransform _usingItemsBg;

	[SerializeField]
	private RectTransform _usingItemsRoot;

	[SerializeField]
	private RectTransform _ownItemsRoot;

	[SerializeField]
	private TerritoryAlchemyAmountPanel _amountPanel;

	[SerializeField]
	private AlchemyResultPanel _resultPanel;

	[SerializeField]
	private ConditionalGroup _canAlchemyConditional;

	[SerializeField]
	private Animator _alchemyEffect;

	private List<TerritoryAlchemyItem_Old> _usingItems;

	private List<TerritoryAlchemyItem_Old> _ownItems;

	private List<IDisposable> _binds;

	private int _ownItemCounter;

	private List<TerritoryAlchemyRewardItem_Old> _rewardItems;

	private int _rewardIndex;

	private int _rewardVersion;

	private int _prevLevel;

	private int _prevRawGauge;

	private int _prevGauge;

	private bool _prevIsFullyGauged;

	private int _tempPrevLevel;

	private List<AlchemyCurrencyData> _playerCurrencies;

	private List<Tweener> _gaugeSequences;

	private static readonly int _action;

	private static readonly int _upgrade;

	private bool _processing;

	public override void Show(TerritoryBuilding building)
	{
	}

	public void Clear()
	{
	}

	public void Reload(bool savePrev = false)
	{
	}

	public void OnClickAlchemyItem(TerritoryAlchemyItem_Old itemOld)
	{
	}

	public void OnClickRewards(int index, int rewardVersion)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStartAlchemy_003Ed__38))]
	public void OnClickStartAlchemy()
	{
	}

	public void OnDisable()
	{
	}

	public bool CheckCanUseMore(AlchemyCurrencyData currencyData)
	{
		return false;
	}

	private TerritoryAlchemyItem_Old AddAlchemyItemOnUsingTab(AlchemyCurrencyData currencyData)
	{
		return null;
	}

	private void AddAlchemyItemOnOwnTab(AlchemyCurrencyData currencyData)
	{
	}

	private void AddRewardItem(ResourceTerritoryAlchemyItem.AlchemyRewards alchemyRewards)
	{
	}

	private TerritoryAlchemyItem_Old FindItem(AlchemyCurrencyData currencyData, bool checkActive = false)
	{
		return null;
	}

	private int OwnCount(AlchemyCurrencyData currencyData)
	{
		return 0;
	}

	private void BuildPlayerCurrencies()
	{
	}

	public void CloseAmountPanel()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public (int, int, int, bool) CalculateGaugeInfo()
	{
		return default((int, int, int, bool));
	}

	public (int, int, bool) GetGaugeInfo(int rawGauge)
	{
		return default((int, int, bool));
	}

	public int CalculateGauge()
	{
		return 0;
	}

	public void SetEffectColor(Color color)
	{
	}
}

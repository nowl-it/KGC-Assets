using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuildingUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetUpgradeGauge_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TerritoryBuildingUI _003C_003E4__this;

		public TerritoryBuildingData buildingData;

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
		public _003CSetUpgradeGauge_003Ed__41(int _003C_003E1__state)
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
	private Image _buildingImage;

	[SerializeField]
	private GameObject _requirementsObj;

	[SerializeField]
	private Text _requirementsText;

	[SerializeField]
	private ConditionalGroup _onClickButtonCond;

	[SerializeField]
	private Text _buttonText;

	[SerializeField]
	private Text _upgradeImmediatelyPriceText;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Transform _buildingSpecsRoot;

	[SerializeField]
	private GameObject _buildingSpecsObj;

	[SerializeField]
	private GameObject _pricesObj;

	[SerializeField]
	private GameObject _upgradeGaugeObj;

	[SerializeField]
	private Text _upgradeTimeText;

	[SerializeField]
	private SimpleTimeGauge _upgradeGauge;

	[SerializeField]
	private Text _shortDesc;

	[SerializeField]
	private List<ImageTextPair> _prices;

	private TerritoryBuildingData _buildingData;

	private bool _isStored;

	private Action<TerritoryBuildingData> _onClick;

	private int _specItemCount;

	private int _priceTypeCount;

	[NonSerialized]
	public string uiState;

	private Coroutine _setUpgradeGauge;

	public TerritoryBuildingData buildingData => null;

	public void Set(TerritoryBuildingData buildingData, bool owned, Action<TerritoryBuildingData> onClick)
	{
	}

	private string GetTimeText(TimeSpan remainTime)
	{
		return null;
	}

	private void AddSpecItem(string title, string desc)
	{
	}

	private void SetPrice(Sprite icon, string text, bool isEnough, int inventoryItemId)
	{
	}

	public void SetBuildingCountText(string text)
	{
	}

	public void SetStored(bool stored)
	{
	}

	public Scene_Territory.BuildData GetBuildData()
	{
		return default(Scene_Territory.BuildData);
	}

	public int GetSpecItemCount()
	{
		return 0;
	}

	public void OnClick()
	{
	}

	public void SetAsFree()
	{
	}

	public void SetUIState(TerritoryBuildingData buildingData, bool showUpgradeGauge)
	{
	}

	public void ShowPrices(bool show)
	{
	}

	public void ShowUpgradeGauge()
	{
	}

	public Transform GetPriceRootTransform()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CSetUpgradeGauge_003Ed__41))]
	private IEnumerator SetUpgradeGauge(TerritoryBuildingData buildingData)
	{
		return null;
	}
}

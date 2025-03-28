using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UpgradableUI : MonoBehaviour
{
	public class AddLevelFuncParam
	{
		public int exp;

		public int currentExp;

		public int currentLevel;
	}

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _valueText;

	[SerializeField]
	private OverableGauge _valueGauge;

	[SerializeField]
	private Text _addAmountText;

	[SerializeField]
	private RectTransform _materialItemsRoot;

	[SerializeField]
	private UpgradeMaterialItem _materialItemPrefab;

	[SerializeField]
	private Button _clearButton;

	[SerializeField]
	private Button _autoSelectButton;

	[SerializeField]
	private ConditionalGroup _upgradeButton;

	[SerializeField]
	private Text _buttonText;

	[SerializeField]
	private Price _upgradePrice;

	[SerializeField]
	private RectTransform _priceLayout;

	[SerializeField]
	private GameObject _autoSelectGroup;

	[SerializeField]
	private ConditionalGroup _autoSelectCond;

	private List<UpgradeMaterialItem> _materialItems;

	private int _currentLevel;

	private int _maxLevel;

	private int _currentExpValue;

	private int _gaugeMaxExpValue;

	private int _maxExpValue;

	private List<(int needExpAmount, int needGold)> _costPool;

	private string _inventoryFieldStr;

	private Action<List<InventoryItem>> _onUpgrade;

	private Func<bool> _checkFunction;

	private string _type;

	private List<Tween> _upgradeEffectTweens;

	private const string TextColor = "FFD264";

	public OverableGauge valueGauge => null;

	public RectTransform materialItemsRoot => null;

	public Button autoSelectButton => null;

	public bool hasUpgradeTarget => false;

	public void SetDefault(List<InventoryItem> inventories, string inventoryFieldStr, Func<bool> checkFunction = null, string type = "")
	{
	}

	public void Set(List<InventoryItem> inventories, int currentValue, int currentLevel, int maxLevel, List<(int needExpAmount, int needGold)> costPool, string inventoryFieldStr, Action<List<InventoryItem>> onUpgrade, Action onValueChanged = null, Func<bool> checkFunction = null, string type = "")
	{
	}

	public void SetLevelText(int level)
	{
	}

	public int GetAddExpAmount()
	{
		return 0;
	}

	public int GetAddLevel(AddLevelFuncParam addLevelFuncParam = null)
	{
		return 0;
	}

	public int GetNeedGold()
	{
		return 0;
	}

	private int GetTotalNeedExpAmount(int targetLevel)
	{
		return 0;
	}

	private bool CheckValueAvailable(int amount)
	{
		return false;
	}

	private bool OnClickUpgradeMaterialItemCheckFunc(int amount)
	{
		return false;
	}

	private void ReloadAddAmount()
	{
	}

	public void OnClickClear()
	{
	}

	public void ToggleAutoSelectGroup()
	{
	}

	public void OnClickAutoSelect(int upgradeLevel)
	{
	}

	private int GetItemAutoUsingCount(int idx, int needToMax)
	{
		return 0;
	}

	public void OnClickUpgrade()
	{
	}

	public void ShowUpgradeEffects(int prevLevel, int curLevel)
	{
	}

	public void ClearUpgradeEffects()
	{
	}

	private void OnDisable()
	{
	}
}

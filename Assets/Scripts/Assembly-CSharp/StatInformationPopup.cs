using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatInformationPopup : PopupPanel
{
	private enum StatType
	{
		Atk = 0,
		Range = 1,
		AttackSpeed = 2,
		MAtk = 3,
		MaxMana = 4,
		Damage = 5,
		AttackDamageMul = 6,
		SkillDamageMul = 7,
		SpecialDamageMul = 8,
		CriticalDamageMul = 9,
		CriticalProb = 10,
		MCriticalDamageMul = 11,
		MCriticalProb = 12,
		Hp = 13,
		HybridDef = 14,
		SuperShieldAdaptability = 15,
		TakeDamage = 16,
		MissRatio = 17,
		Def = 18,
		MDef = 19,
		HealEfficiency = 20,
		Guard = 21,
		MoveSpeed = 22,
		DefDen = 23,
		DefPen = 24,
		HybridDrain = 25,
		Execution = 26
	}

	[SerializeField]
	private StatInformationPopupItem _statItemPrefab;

	[SerializeField]
	private RectTransform _popupItemsRoot;

	[SerializeField]
	private TabManager _categoryTabManager;

	[SerializeField]
	private GameObject _categoryTabsRoot;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private LayoutFitter _statsFitter;

	private List<StatInformationPopupItem> _statItems;

	private bool _inited;

	private int _lastSelectedTabIdx;

	private Dictionary<StatType, StatInformationPopupItem.StatInfoCategory> statInfoCategoryDict;

	private void Init()
	{
	}

	public new void Show()
	{
	}

	private void OnClickTab(int idx)
	{
	}

	private void Reload(int idx)
	{
	}
}

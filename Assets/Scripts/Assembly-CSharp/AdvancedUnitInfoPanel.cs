using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancedUnitInfoPanel : MonoBehaviour, IClosable
{
	public static AdvancedUnitInfoPanel Instance;

	[SerializeField]
	private TabManager _tabManager;

	[SerializeField]
	private TreasureUIItem _treasurePreview;

	[SerializeField]
	private Text _cardLevelText;

	[SerializeField]
	private ConditionalImage _cardLevelBox;

	[SerializeField]
	private UnitInfoPanelBase _unitInfoPanelBase;

	[SerializeField]
	private LayoutFitter _layoutFitter;

	[SerializeField]
	private CanvasGroup _cg;

	[Space(20f)]
	[SerializeField]
	private TreasureUIItem _treasureUIItem;

	[SerializeField]
	private TreasureSkillUI _treasureSkillUI;

	[SerializeField]
	private Text _treasureNotEquippedText;

	[SerializeField]
	private List<AccessorySynergyToolTip> _accSynergyTooltip;

	[SerializeField]
	private LayoutFitter _accSynergyTooltipsLayoutFitter;

	[SerializeField]
	private Text _accessorySynergyNotAppliedText;

	[SerializeField]
	[Space(20f)]
	private LayoutFitter _itemInfoLayoutFitter;

	[SerializeField]
	private List<ItemInfoPanel> _itemInfoPanels;

	[SerializeField]
	private GameObject _noEquippedItemsObj;

	[Space(20f)]
	[SerializeField]
	private RectTransform _unitStatGroupUIsRoot;

	[SerializeField]
	private UnitStatGroupUI _unitStatGroupUIPrefab;

	[SerializeField]
	private LayoutFitter _unitStatGroupLayoutFitter;

	private List<UnitStatGroupUI> _unitStatGroupUIs;

	[NonSerialized]
	public RectTransform rectTransform;

	private GameUnit _gameUnit;

	private float _timeLimit;

	public void Show(GameUnit gameUnit)
	{
	}

	private void Update()
	{
	}

	private void Reload(int idx)
	{
	}

	public void ReloadSkillDesc(bool ignoreLastSkill = false)
	{
	}

	private void ReloadTreasureAccessoryTab()
	{
	}

	private void ReloadItemTab()
	{
	}

	private void ReloadStatTab()
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

using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ArenaSeasonEventTriggerPanel : BlurPopupPanel
{
	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private ConditionalGroup _grandArenaCond;

	[SerializeField]
	private List<Image> _eventTriggerIcons;

	[SerializeField]
	private List<Text> _eventTriggerTexts;

	[SerializeField]
	private List<Text> _eventTriggerDesc;

	[SerializeField]
	private Text _regionRoleUnitText;

	[SerializeField]
	private ScrollRect _unitItemsScrollRect;

	[SerializeField]
	private RectTransform _unitItemsRoot;

	[SerializeField]
	private ArenaSeasonEventTriggerUnitItem _unitItemPrefab;

	[SerializeField]
	private GameObject _hasNotAppliedUnitObject;

	private List<ArenaSeasonEventTriggerUnitItem> _unitItems;

	private List<ResourceEventTrigger> _resEventTriggers;

	public override void Show()
	{
	}

	private void Reload()
	{
	}

	private void ReloadEventTrigger(PvPInfoResponseModel pvpData)
	{
	}

	private void ReloadUnitItems(PvPInfoResponseModel pvpData)
	{
	}

	private void SetUnitItem(int idx, ResourceUnit resUnit)
	{
	}

	public void ShowRoleOrRegionTooltip(int idx)
	{
	}

	public override bool Close()
	{
		return false;
	}
}

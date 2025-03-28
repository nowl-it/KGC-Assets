using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAlchemyPanel : TerritoryBuildingMenuBase
{
	[SerializeField]
	[Space(20f)]
	private ConditionalGroup _lockCond;

	[SerializeField]
	private List<Text> _alchemyPhaseText;

	[SerializeField]
	private Text _reqPointText;

	[SerializeField]
	private Text _alchemyLockedText;

	[SerializeField]
	private RectTransform _alchemyLevelIndicatorRoot;

	[SerializeField]
	private ConditionalSetActive _alchemyLevelIndicatorPrefab;

	private List<ConditionalSetActive> _alchemyLevelIndicatorIcons;

	[SerializeField]
	private RectTransform _rewardItemsRoot;

	[SerializeField]
	private TerritoryAlchemyRewardItem _rewardItemPrefab;

	private List<TerritoryAlchemyRewardItem> _rewardItems;

	[SerializeField]
	private TerritoryAlchemyCurrencyPanel _alchemyCurrencyPanel;

	[SerializeField]
	private AlchemyResultPanel _resultPanel;

	[SerializeField]
	private AlchemyInformationPanel _alchemyInformationPanel;

	[SerializeField]
	private ConditionalText _alchemyInformationPanelToggle;

	[SerializeField]
	private Text _alchemyCurrencyItemPointText;

	private int _index;

	private int _rewardIndex;

	private int _rewardVersion;

	private ResourceTerritoryBuilding _resBuilding;

	private List<ResourceTerritoryAlchemyItem> _resAlchemyItems;

	private bool _isLocked => false;

	public int alchemyReqPoint => 0;

	protected override void Awake()
	{
	}

	public override void Show(TerritoryBuilding building)
	{
	}

	private void Reload()
	{
	}

	private void ReloadIndicator()
	{
	}

	private void ReloadReward()
	{
	}

	private void Clear()
	{
	}

	public void OnClickArrow(int idx)
	{
	}

	public void OnClickRewards(int index, int rewardVersion)
	{
	}

	public override bool Close()
	{
		return false;
	}

	public void ShowResult(RewardListResponseData data, int jackpotLevel)
	{
	}

	public void ToggleAlchemyInformationPanel()
	{
	}
}

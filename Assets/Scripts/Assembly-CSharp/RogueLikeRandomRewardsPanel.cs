using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeRandomRewardsPanel : RogueLikeEventPanel
{
	public struct RewardData
	{
		public Item item;

		public RogueLikeArtifactModel artifact;
	}

	[Serializable]
	public struct RewardDataSaveData
	{
		public Scene_Game.SaveRogueLikeItemData item;

		public RogueLikeArtifactModel.SaveData artifact;
	}

	private static RogueLikeRandomRewardsPanel _instance;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private RogueLikeRandomRewardsPanelItem _itemPrefab;

	[SerializeField]
	private Transform _itemsRoot;

	[SerializeField]
	private Text _rewardLeftText;

	[SerializeField]
	private Text _buttonText;

	[SerializeField]
	private ConditionalGroup _selectButtonConditionals;

	[SerializeField]
	private GameObject _itemClickBlocker;

	private List<RogueLikeRandomRewardsPanelItem> _items;

	private List<RewardData> _rewardDatas;

	private int _selectedReward;

	private bool _useEvent;

	private Item.GodItemFromType _godItemFromType;

	private bool _setBG;

	public static RogueLikeRandomRewardsPanel Instance => null;

	private void SetBG()
	{
	}

	public override void BeforeOpen(bool isRepeat)
	{
	}

	public override void Show(ResourceRogueLikeEvent resEvent, List<ResourceRogueLikeEvent.Option> options)
	{
	}

	public void Show(string title, string desc)
	{
	}

	public void SetGodItemFromType(Item.GodItemFromType fromType)
	{
	}

	private RogueLikeRandomRewardsPanelItem InstantiateOrGetItem(int index)
	{
		return null;
	}

	public override void SetItem(int index, Constants.RogueLikeItemType type, int tier, int id, int amount, string icon = null, string customText = null)
	{
	}

	public void SetReward(int index, RewardData data)
	{
	}

	public override void OnClickOption(GameObject go, ResourceRogueLikeEvent.Option option)
	{
	}

	public void OnClickSelect()
	{
	}

	public void SetSelectButtonY(float y)
	{
	}

	public override void SetButtonText(string text)
	{
	}

	public override void BlockClickItem(bool block)
	{
	}

	public override void SetRewardLeftText(int curCount, int totalCount)
	{
	}

	public RogueLikeRandomRewardsPanelItem GetItem(int index)
	{
		return null;
	}
}

using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAlchemyRewardItem_Old : MonoBehaviour
{
	[SerializeField]
	private ClickableShopItemIcon _clickableShopItem;

	[SerializeField]
	private List<Text> _rewardAmountTexts;

	[SerializeField]
	private GameObject _selectedEffectObj;

	[SerializeField]
	private Image _tempRewardBg;

	public ResourceTerritoryAlchemyItem.AlchemyRewards item;

	private TerritoryAlchemyPanel_Old _parent;

	private Action _callBack;

	private Tweener _sequence;

	public void Set(ResourceTerritoryAlchemyItem.AlchemyRewards item, TerritoryAlchemyPanel_Old parent)
	{
	}

	public void SetSelected(bool select)
	{
	}

	public void SetAsTempReward(bool isTemp)
	{
	}

	public void OnClick()
	{
	}
}

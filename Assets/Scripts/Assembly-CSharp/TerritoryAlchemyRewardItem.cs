using System;
using System.Collections.Generic;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAlchemyRewardItem : MonoBehaviour
{
	[SerializeField]
	private ClickableShopItemIcon _clickableShopItem;

	[SerializeField]
	private List<Text> _rewardAmountTexts;

	[CanBeNull]
	[SerializeField]
	private Button _alchemyButton;

	public ResourceTerritoryAlchemyItem.AlchemyRewards item;

	private TerritoryAlchemyPanel _parent;

	private Action _callBack;

	private Tweener _sequence;

	public void Set(ResourceTerritoryAlchemyItem.AlchemyRewards item, TerritoryAlchemyPanel parent, bool locked)
	{
	}

	public void OnClick()
	{
	}
}

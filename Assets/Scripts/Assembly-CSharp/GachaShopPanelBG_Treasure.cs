using System;
using UnityEngine;
using UnityEngine.UI;

public class GachaShopPanelBG_Treasure : GachaShopPanelBG
{
	[SerializeField]
	private Text _gachaName;

	[SerializeField]
	private Text _gachaDesc;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Image _showDetailButton;

	public ResourceGacha.Pickup pickup;

	private bool _isPickupGacha;

	public override void Set(ResourceGacha resGacha)
	{
	}

	public override Action GetAfterBuyGachaCallback()
	{
		return null;
	}

	public void Reload()
	{
	}

	public override void OnChangeGachaCellIdx(int idx)
	{
	}

	public void OnClickTreasureDetailButton()
	{
	}
}

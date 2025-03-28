using UnityEngine;
using UnityEngine.UI;

public class GachaShopPanelBG_TreasureMultiPickup : GachaShopPanelBG, IGachaCeilSelectable
{
	[SerializeField]
	private Text _gachaName;

	[SerializeField]
	private Text _pickupDesc;

	[SerializeField]
	private TreasureCardGachaItem[] _treasureCards;

	[SerializeField]
	private Image _gachaCeilSelectButton;

	public TreasureGachaCeilSelectPanel treasureGachaCeilSelectPanel;

	private ResourceGachaPool _gachaPool => null;

	public override void Set(ResourceGacha resGacha)
	{
	}

	public void OnClickTreasureDetailButton(int index)
	{
	}

	public void ReloadGachaCeilSelectButton()
	{
	}

	public void OnClickSelectGachaCeil()
	{
	}
}

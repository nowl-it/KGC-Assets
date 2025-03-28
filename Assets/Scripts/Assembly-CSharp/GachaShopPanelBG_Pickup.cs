using UnityEngine;
using UnityEngine.UI;

public class GachaShopPanelBG_Pickup : GachaShopPanelBG
{
	[SerializeField]
	private Text _gachaName;

	[SerializeField]
	private Text _pickupDesc;

	[SerializeField]
	private Image[] _unitIllusts;

	[SerializeField]
	private Text[] _unitSubNames;

	[SerializeField]
	private Text[] _unitNames;

	public override void Set(ResourceGacha resGacha)
	{
	}

	public void OnClickUnitDetailButton(int index)
	{
	}
}

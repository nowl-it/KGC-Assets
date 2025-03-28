using UnityEngine;
using UnityEngine.UI;

public class FirstPurchaseEventPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private ClickableShopItemIcon[] _itemIcons;

	[SerializeField]
	private UnitIllust _unitIllust;

	[SerializeField]
	private Text _giveUnitDescText;

	[SerializeField]
	private Text _ifHasUnitDescText;

	public void Show()
	{
	}

	public void OnClickGoToShop()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}

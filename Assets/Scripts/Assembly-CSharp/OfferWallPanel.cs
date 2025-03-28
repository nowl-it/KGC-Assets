using UnityEngine;
using UnityEngine.UI;

public class OfferWallPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Button OfferWall_Tapjoy_Gem;

	[SerializeField]
	private Button OfferWall_Tapjoy_Food;

	[SerializeField]
	private Button OfferWall_Fyber_Gem;

	[SerializeField]
	private Button OfferWall_Fyber_Food;

	public static bool HasAvailableOfferWall()
	{
		return false;
	}

	public void Show()
	{
	}

	public void OnClickTapjoyGem()
	{
	}

	public void OnClickFyberGem()
	{
	}

	public void OnClickTapjoyFood()
	{
	}

	public void OnClickFyberFood()
	{
	}

	public void Hide()
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

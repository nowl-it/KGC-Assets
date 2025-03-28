using UnityEngine;
using UnityEngine.UI;

public class ShopShortCutManager : MonoBehaviour
{
	[SerializeField]
	private Image _seasonalEventIcon;

	[SerializeField]
	private Image _clanIcon;

	[SerializeField]
	private Image _arenaIcon;

	[SerializeField]
	private Image _hardModeIcon;

	private bool CheckLevelAvailable(int levelLimit)
	{
		return false;
	}

	private void CloseAlreadyOpenedPopup()
	{
	}

	private void DoShortCut(LobbyShortCutController.ShortCutInfo shortCutInfo)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void ShowSeasonalEventShop()
	{
	}

	public void ShowClanShop()
	{
	}

	public void ShowArenaShop()
	{
	}

	public void ShowHardModeShop()
	{
	}
}

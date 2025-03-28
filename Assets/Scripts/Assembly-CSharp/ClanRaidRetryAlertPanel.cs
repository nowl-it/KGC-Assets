using Awesomepiece.Model;
using UnityEngine;

public class ClanRaidRetryAlertPanel : PopupPanel
{
	[SerializeField]
	private ClanRaidDeckItem _retryDeck;

	[SerializeField]
	private GameObject _checkIcon;

	private bool _check;

	public void Show(ClanRaidDeckInfo deck)
	{
	}

	public override void OnClickClose()
	{
	}

	public void OnClickDontShowThisSeason()
	{
	}
}

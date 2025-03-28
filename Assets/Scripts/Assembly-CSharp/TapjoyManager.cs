using System;
using TapjoyUnity;

public class TapjoyManager
{
	private TJPlacement _lobbyPlacement;

	private TJPlacement _gamePlacement;

	private TJPlacement _offerwallMeatPlacement;

	private TJPlacement _offerwallGemPlacement;

	private Action<bool> _lobbyCallback;

	private Action<bool> _gameCallback;

	private bool _requestLobby;

	private bool _requestGame;

	private bool _requestOfferwall;

	private bool _inited;

	public static TapjoyManager Instance { get; }

	public void Init()
	{
	}

	public void InitLobby()
	{
	}

	public void InitGame()
	{
	}

	public void InitOfferwall()
	{
	}

	private void ReadyAd()
	{
	}

	private void ReadyOfferwall()
	{
	}

	public void ShowVideoAd(Action<bool> callback, Action failCallback = null)
	{
	}

	public void ShowOfferwallGem(Action failCallback = null)
	{
	}

	public void ShowOfferwallMeat(Action failCallback = null)
	{
	}

	public bool IsAdReady()
	{
		return false;
	}

	private bool IsLobbyAdReady()
	{
		return false;
	}

	private bool IsGameAdReady()
	{
		return false;
	}

	private bool IsOfferwallGemReady()
	{
		return false;
	}

	private bool IsOfferwallMeatReady()
	{
		return false;
	}

	public void OnConnectSuccess()
	{
	}

	public void OnVideoComplete(TJPlacement placement)
	{
	}

	private void OnAwardCurrencyResponse(string currencyName, int balance)
	{
	}

	private void OnVideoError(TJPlacement placement, string error)
	{
	}

	private void OnRequestFailure(TJPlacement placement, string error)
	{
	}
}

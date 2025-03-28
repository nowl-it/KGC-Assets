using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Ump.Api;
using UnityEngine.UI;

public class AdmobManager
{
	private RewardedAd _ad;

	private Action<bool> _callback;

	private bool _inited;

	private bool _reward;

	private const string AdUnitId = "ca-app-pub-2704659959026536/6703722186";

	public static AdmobManager Instance { get; }

	public void Init()
	{
	}

	private void ReadyAd()
	{
	}

	private void HandleUserEarnedReward(Reward reward)
	{
	}

	private void HandleRewardedAdClosed()
	{
	}

	private void HandleAdPaidEvent(AdValue adValue)
	{
	}

	private void HandleAdFailed()
	{
	}

	public void ShowAd(Action<bool> callback, Action failCallback)
	{
	}

	public bool IsReady()
	{
		return false;
	}

	private void OnConsentInfoUpdated(FormError consentError)
	{
	}

	public void ShowPrivacyOptionsForm(Button button)
	{
	}

	public bool GetPrivacyOptionFromButtonInteractable()
	{
		return false;
	}
}

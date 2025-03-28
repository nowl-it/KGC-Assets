using System;
using UnityEngine.Advertisements;

public class UnityAdsManager : IUnityAdsLoadListener, IUnityAdsShowListener, IUnityAdsInitializationListener
{
	private Action<bool> _adsCallback;

	private bool isReady;

	public static UnityAdsManager Instance { get; }

	public void Init()
	{
	}

	public bool IsReady()
	{
		return false;
	}

	public void ShowRewardedAd(Action<bool> callback = null, Action failCallback = null)
	{
	}

	public void OnUnityAdsAdLoaded(string placementId)
	{
	}

	public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
	{
	}

	public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
	{
	}

	public void OnUnityAdsShowStart(string placementId)
	{
	}

	public void OnUnityAdsShowClick(string placementId)
	{
	}

	public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
	{
	}

	public void OnInitializationComplete()
	{
	}

	public void OnInitializationFailed(UnityAdsInitializationError error, string message)
	{
	}
}

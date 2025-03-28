using TapjoyUnity;
using UnityEngine;

public class PlacementExample : MonoBehaviour
{
	public TJPlacement directPlayPlacement;

	public TJPlacement offerwallPlacement;

	public TJPlacement samplePlacement;

	public string samplePlacementName;

	public string output;

	public bool shouldPreload;

	public bool contentIsReadyForPlacement;

	private GUIStyle inputStyle;

	private GUIStyle headerStyle;

	private GUIStyle outputStyle;

	private int fontSize;

	private float startY;

	private float centerX;

	private float buttonWidth;

	private float buttonHeight;

	private float headerHeight;

	private float halfButtonWidth;

	private float thirdButtonWidth;

	private float yPadding;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void HandlePlacementRequestSuccess(TJPlacement placement)
	{
	}

	public void HandlePlacementRequestFailure(TJPlacement placement, string error)
	{
	}

	public void HandlePlacementContentReady(TJPlacement placement)
	{
	}

	public void HandlePlacementContentShow(TJPlacement placement)
	{
	}

	public void HandlePlacementContentDismiss(TJPlacement placement)
	{
	}

	public void HandlePlacementOnClick(TJPlacement placement)
	{
	}

	private void HandleOnPurchaseRequest(TJPlacement placement, TJActionRequest request, string productId)
	{
	}

	private void HandleOnRewardRequest(TJPlacement placement, TJActionRequest request, string itemId, int quantity)
	{
	}

	public void HandleAwardCurrencyResponse(string currencyName, int balance)
	{
	}

	public void HandleAwardCurrencyResponseFailure(string error)
	{
	}

	public void HandleGetCurrencyBalanceResponse(string currencyName, int balance)
	{
	}

	public void HandleGetCurrencyBalanceResponseFailure(string error)
	{
	}

	public void HandleSpendCurrencyResponse(string currencyName, int balance)
	{
	}

	public void HandleSpendCurrencyResponseFailure(string error)
	{
	}

	public void HandleEarnedCurrency(string currencyName, int amount)
	{
	}

	public void HandleVideoStart(TJPlacement placement)
	{
	}

	public void HandleVideoError(TJPlacement placement, string message)
	{
	}

	public void HandleVideoComplete(TJPlacement placement)
	{
	}

	private void InitUI()
	{
	}

	private void OnGUI()
	{
	}

	private void ResetCurrencyLabel()
	{
	}

	private string getDummySkuDetails()
	{
		return null;
	}

	private string getDummyPurchaseData()
	{
		return null;
	}

	private string getDummyDataSignature()
	{
		return null;
	}
}

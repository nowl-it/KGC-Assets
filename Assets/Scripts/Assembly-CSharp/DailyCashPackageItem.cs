using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class DailyCashPackageItem : ShopItem
{
	public static readonly string DAILY_CASH_ENABLED;

	public static readonly string DAILY_CASH_REMAIN;

	public static readonly string DAILY_CASH_POST;

	public static readonly string DAILY_CASH2_ENABLED;

	public static readonly string DAILY_CASH2_REMAIN;

	public static readonly string DAILY_CASH2_POST;

	public static readonly string DAILY_GOLD_ENABLED;

	public static readonly string DAILY_GOLD_REMAIN;

	public static readonly string DAILY_GOLD_POST;

	public static readonly string DAILY_HEART_ENABLED;

	public static readonly string DAILY_HEART_REMAIN;

	public static readonly string DAILY_HEART_POST;

	public Text efficiency;

	public new ImageTextPair name;

	public Text dailyText;

	public Text totalText;

	public Text firstText;

	public Text beforeBuyText;

	public Text remainDayText;

	public GameObject postStandBy;

	public GameObject postReceived;

	public GameObject button;

	public GameObject buyCompleteText;

	public ClickableShopItemIcon[] itemIcons;

	[Header("골드패키지")]
	public Text extraText;

	private bool isInit;

	public override void Init(ShopItemModel model)
	{
	}

	public override void Init(int id)
	{
	}

	public void Reload()
	{
	}
}

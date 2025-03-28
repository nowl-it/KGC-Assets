using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class PackageItem : ShopItem
{
	[Serializable]
	public enum PackageType
	{
		None = 0,
		StepUp = 1,
		CustomGrowth = 2,
		GoldMine = 3,
		CashMine = 4,
		SeasonPass = 5,
		TowerPass = 6,
		TerritoryPass = 7,
		Holiday = 8,
		UnitBundle = 9,
		SkinBundle = 10
	}

	public ImageTextPair packIcon;

	public Image boxKeyImage;

	public Text boxKeyCount;

	public Text expCount;

	public Text unitExpCount;

	public Text soulCount;

	public Text unitSoulCount;

	public Image cashImage;

	public Text cashCount;

	public Image goldImage;

	public Text goldCount;

	public Image heartImage;

	public Text heartCount;

	public Text skinTokenCount;

	[Header("아래 유닛 관련 링킹은 필요한 경우에만")]
	public Image unitImage;

	public Text unitNameText;

	public Text unitSubNameText;

	public GameObject defaultUnitImage;

	public RectTransform characterRoot;

	public GridLayoutGroup iconsGridLayoutGroup;

	public Image[] unitIcons;

	public List<SerializedList<Image>> unitGradationImages;

	public Text[] unitChoiceTexts;

	public Text[] unitChoiceStateTexts;

	public ClickableShopItemIcon[] itemIcons;

	public Image bossTagImage;

	public Text remainTimeText;

	public GameObject remainTimeTextBackground;

	private DateTime _untilAt;

	private bool useUntilAt;

	public PackageItemArtifactIcon[] artifactIcons;

	public PackageItemTreasureIcon[] treasureIcons;

	public GameObject soldOutObj;

	public Image newIcon;

	public Image shopItemBg;

	public Image[] artifactItemBg;

	public PackageType packageType;

	private int _enabledItemIconCount;

	private GameObject unitObj;

	[SerializeField]
	private ConditionalGroup _packageStateCond;

	public List<int> choiceUnits;

	[Header("Holiday 패키지 배너 프리펩에만 이용. Type에 Holiday 키값 넣고, idx에 순서를 넣는다.")]
	public string holidayType;

	public int packageTypeIdx;

	private DateTime _lastUpdateTime;

	[SerializeField]
	private Gauge _rewardGauge;

	[SerializeField]
	private Text _rewardAmountText;

	[SerializeField]
	private ConditionalGroup _stepUpPackageConditional;

	public override void Init(ShopItemModel model)
	{
	}

	public void Update()
	{
	}

	private void SetItemIcon(int resInventoryItemId, int count, bool showExpText = false, float scale = 1f)
	{
	}

	private void SetItemIcon(Sprite icon, int resInventoryItemId, int count, bool showExpText = false, float scale = 1f)
	{
	}

	private void SetItemIcon(Sprite icon, ResourceInventoryItem resInventoryItem, int count, bool showExpText = false, float scale = 1f)
	{
	}

	public void InitByPrefabType(int bundlePackageIndex = -1)
	{
	}

	private void ReloadUnit()
	{
	}

	public void ReloadChoiceUnitPackage()
	{
	}

	public void OnClickChoiceUnit(int index)
	{
	}

	private void InitCustomGrowthPackage()
	{
	}

	private void InitGoldMine()
	{
	}

	private void InitCashMine()
	{
	}

	private void InitStepUpPackage()
	{
	}

	private void InitSeasonPassPackage()
	{
	}

	private void InitTerritoryPassPackage()
	{
	}

	private void InitHolidayBanner(string holidayType)
	{
	}

	private void InitUnitBundle(int index)
	{
	}

	private void InitSkinBundle(int index)
	{
	}

	private void InitSkinBundleImpl(ResourceUnit resUnit, ResourceSkin resSkin, ResourceInventoryItem resToken, int tokenCount)
	{
	}

	public void ShowCustomGrowthPanel()
	{
	}

	public void ShowStepUpPackagePopup()
	{
	}

	public void ShowMinePanel(bool gold)
	{
	}

	public void ShowSeasonPassPanel()
	{
	}

	public void ShowTerritoryPassPanel()
	{
	}

	public void OnClickPackageBanner()
	{
	}

	public void OnClickHolidayPackageBanner()
	{
	}

	public void OnClickUnitBundlePackagePanel()
	{
	}

	public void OnClickSkinBundlePackagePanel()
	{
	}
}

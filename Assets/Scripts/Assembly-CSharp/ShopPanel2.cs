using System.Collections.Generic;
using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel2 : BaseLobbyPanel
{
	public static ShopPanel2 Instance;

	[ComponentConnect]
	public RectTransform packageArea;

	[ComponentConnect]
	public RectTransform playerPackageArea;

	[ComponentConnect]
	public RectTransform eventPackageArea;

	[ComponentConnect]
	public RectTransform dailyArea;

	[ComponentConnect]
	public RectTransform boxArea;

	[ComponentConnect]
	public RectTransform artifactBoxArea;

	[ComponentConnect]
	public RectTransform cashArea;

	[ComponentConnect]
	public RectTransform goldArea;

	[ComponentConnect]
	public RectTransform LinkArea;

	[ComponentConnect]
	public RectTransform layoutContent;

	public PackageItem packagePrefab;

	public ScrollRect packageScroll;

	public ScrollRect packageHardScroll;

	public Image[] packageScrollArrows;

	private Sequence[] packageScrollArrowSeq;

	public PackageItem playerPackagePrefab;

	public ScrollRect playerPackageScroll;

	public Image[] playerPackageScrollArrows;

	private Sequence[] _playerPackageScrollArrowSeq;

	public RectTransform packageAreaContent;

	public RectTransform packageHardAreaContent;

	public RectTransform playerPackageAreaContent;

	public List<PackageItem> packageItems;

	public List<PackageItem> packageHardItems;

	public List<PackageItem> playerPackageItems;

	public ShopItem[] dailyItems;

	public GameObject dailyNewBadge;

	public GachaItem[] gachaItems;

	public GachaItem[] artifactGachaItems;

	public ShopItem[] cashItems;

	public ShopItem[] goldItems;

	public ScrollRect scrollView;

	[ComponentConnect]
	public BuyConfirmPanel buyConfirmPanel;

	[ComponentConnect]
	public GachaPanel gachaPanel;

	[ComponentConnect]
	public SelectExpPanel selectExpPanel;

	[ComponentConnect]
	public ShopRefreshPanel shopRefreshPanel;

	public Text expRefreshTime;

	public Text gachaRefreshTime;

	public Text artifactGachaRefreshTime;

	public GameObject expInfoPopup;

	public GameObject gachaInfoPopup;

	[ComponentConnect]
	public CanvasGroup artifactGachaInfoPopup;

	public bool skipScrollInit;

	public Button dailyShopRefreshButton;

	public Text dailyShopRefreshText;

	[ComponentConnect]
	public DailyCashPackageItem dailyCashPackage;

	public Image[] packageToggleIcons;

	public GameObject packageToggleParent;

	public GameObject packageTitle;

	public int packageIdx;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Init()
	{
	}

	public override void OnPanelSetStart()
	{
	}

	public override void OnPanelEnabled()
	{
	}

	private void Update()
	{
	}

	public void Reload()
	{
	}

	public bool IsGachaFree(int tier)
	{
		return false;
	}

	public void OnClickDailyInfo()
	{
	}

	public void OnClickBoxInfo()
	{
	}

	public void OnClickArtifactBoxInfo()
	{
	}

	private void SetGachaStack(int box1Stack, int box2Stack, int box3Stack)
	{
	}

	private void SetArtifactGachaStack(int[] stacks)
	{
	}

	private void SetGachaKey(int box1Key, int box2Key, int box3Key)
	{
	}

	private void SetArtifactGachaKey(int[] boxKeys)
	{
	}

	public void SetCashItems(ShopItemModel[] items)
	{
	}

	public void PackageScrollChanged()
	{
	}

	public void PlayerPackageScrollChanged()
	{
	}

	public void OnClickProvabilityInfo()
	{
	}

	public void OnClickRefreshDailyShop()
	{
	}

	public void OnTogglePackage(int idx)
	{
	}

	private void SetPackageToggle(int idx)
	{
	}

	public void ReloadPackageItems()
	{
	}
}

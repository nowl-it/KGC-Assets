using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : BaseLobbyPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDevResetDailyShopRefreshCount_003Ed__157 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDevSetUnitBundlePackageUntilAt_003Ed__159 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public static ShopPanel Instance;

	[Space(20f)]
	public TabManager tabManager;

	public GameObject recommendTab;

	public GameObject packageTab;

	public GameObject dailyTab;

	public GameObject specialTab;

	public GameObject subscribeTab;

	public List<RectTransform> enabledTabs;

	public List<RectTransform> disabledTabs;

	public GameObject moneyTab;

	[Space(20f)]
	public RectTransform recommendPackageArea;

	public RectTransform recommendScroll;

	public RectTransform subscribeScroll;

	public ShopRecommendationCarouselView recommendationCarouselView;

	public ScrollRect recommendAllLayout;

	[Space(20f)]
	public RectTransform unitBundlePackageArea;

	public RectTransform specialPackageArea;

	public ScrollRect specialPackageScroll;

	[Space(20f)]
	public GameObject unitBundlePackageToggle;

	public GameObject specialPackageToggle;

	public TabManager specialTabManager;

	[Space(20f)]
	public List<PackageItem> subscribePackages;

	public DailyCashPackageItem dailyCashPackage;

	public DailyCashPackageItem dailyCashPackage2;

	public DailyCashPackageItem dailyGoldPackage;

	public DailyCashPackageItem dailyHeartPackage;

	[Space(20f)]
	public RectTransform eventPackageArea;

	public RectTransform[] holidayPackageAreas;

	public RectTransform playerPackageArea;

	public GameObject packageTabNewBadge;

	public TabManager packageTabManager;

	public RectTransform packageTabsLayout;

	public GameObject playerPackageToggle;

	public GameObject eventPackageToggle;

	public GameObject[] holidayPackageToggles;

	[Space(20f)]
	public RectTransform dailyArea;

	public Text expRefreshTime;

	public GameObject expInfoPopup;

	public ShopRefreshPanel shopRefreshPanel;

	[Space(20f)]
	public GameObject dailyNewBadge;

	public Image dailyHeroNewBadge;

	[Space(20f)]
	[Space(20f)]
	public RectTransform moneyScroll;

	public RectTransform currencyLayoutGroup;

	public RectTransform currencyArea;

	public RectTransform expItemArea;

	public RectTransform boxKeyItemArea;

	public Button offerWallButton;

	[Space(20f)]
	public ScrollRect moneyScrollRect;

	public Image goldFreeBadge;

	public TabManager moneyTabManager;

	[NonSerialized]
	public List<GameObject> recommendPackageItems;

	[Space(20f)]
	public List<PackageItem> eventPackageItems;

	public Dictionary<string, List<PackageItem>> holidayPackageItems;

	public List<PackageItem> unitBundlePackages;

	public List<PackageItem> specialPackages;

	public List<PackageItem> playerPackageItems;

	public List<ShopItem> dailyItems;

	public List<ShopItem> moneyItems;

	[Space(20f)]
	public PackageItem packagePrefab_L;

	public PackageItem packagePrefab_M;

	public PackageItem packagePrefab_XL;

	public ShopItem dailyPackagePrefab;

	public ShopItem moneyPackagePrefab;

	public PackageItem moneyPackagePrefab_2;

	private BuyConfirmPanel _buyConfirmPanel;

	private BuyPackageConfrimPanel _buyPackageConfirmPanel;

	private BuyGachaConfirmPanel _buyGachaConfirmPanel;

	private BuyGachaConfirmPanel _buyGachaConfirmPanel_Artifact;

	private GachaPanel _gachaPanel;

	private TreasureGachaResultPanel _treasureGachaResultPanel;

	private SelectExpPanel _selectExpPanel;

	private BuyItemPanel _buyItemPanel;

	private BuyItemPanel_Voucher _buyItemPanelVoucher;

	private GachaNewUnitPanel _gachaNewUnitPanel;

	private OfferWallPanel _offerWallPanel;

	private CustomGrowthPanel _customGrowthPanel;

	private StepUpPackagePopup _stepUpPackagePopup;

	private UnitBundlePackagePanel _unitBundlePackagePanel;

	private SkinBundlePackagePanel _skinBundlePackagePanel;

	private ChoicePackageUnitPanel _choicePackageUnitPanel;

	private bool isSummonInit;

	private int summonTotalCount;

	private bool readyToReload;

	private bool isReloaded;

	private DateTime _lastUpdateTime;

	private List<PackageItem> _alwaysActivatedExpItemPackages;

	private List<PackageItem> _alwaysActivatedBoxKeyPackages;

	private bool _devSet;

	public BuyConfirmPanel buyConfirmPanel => null;

	public BuyPackageConfrimPanel buyPackageConfirmPanel => null;

	public BuyGachaConfirmPanel buyGachaConfirmPanel => null;

	public BuyGachaConfirmPanel buyGachaConfirmPanel_Artifact => null;

	public GachaPanel gachaPanel => null;

	public TreasureGachaResultPanel treasureGachaResultPanel => null;

	public SelectExpPanel selectExpPanel => null;

	public BuyItemPanel buyItemPanel => null;

	public BuyItemPanel_Voucher buyItemPanelVoucher => null;

	public GachaNewUnitPanel gachaNewUnitPanel => null;

	public OfferWallPanel offerWallPanel => null;

	public CustomGrowthPanel customGrowthPanel => null;

	public bool isStepUpPackagePopupInstantiated => false;

	public StepUpPackagePopup stepUpPackagePopup => null;

	public UnitBundlePackagePanel unitBundlePackagePanel => null;

	public SkinBundlePackagePanel skinBundlePackagePanel => null;

	public ChoicePackageUnitPanel choicePackageUnitPanel => null;

	public bool useEventNameTag { get; private set; }

	public List<ShopItemModel> hasBundlePackageSkins => null;

	public void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Init()
	{
	}

	public override void OnPanelEnabled()
	{
	}

	public void UpdateDaily()
	{
	}

	private void Update()
	{
	}

	public void Reload()
	{
	}

	public void Reload(bool init)
	{
	}

	public void ReloadCards()
	{
	}

	public void ReloadRecommendPackage()
	{
	}

	public void ReloadUnitBundlePackage()
	{
	}

	public void ReloadSpecialPackage()
	{
	}

	public void ReloadSubscribePackage()
	{
	}

	public void ReloadPlayerPackage()
	{
	}

	public void ReloadEventPackage()
	{
	}

	public void ReloadPackageBadge()
	{
	}

	public void ReloadDaily()
	{
	}

	public void ReloadMoney(int idx)
	{
	}

	public bool IsGoldAdAvailable()
	{
		return false;
	}

	private bool IsDailyUnitExpItemFree()
	{
		return false;
	}

	public void SetCashItems(ShopItemModel[] items)
	{
	}

	public void OnClickRefreshDailyShop()
	{
	}

	public void OnClickDailyInfo()
	{
	}

	public void OnClickProvabilityInfo()
	{
	}

	public void ReloadDailyCashPackages()
	{
	}

	public void OpenOfferWallButton()
	{
	}

	private void ReloadShopTabEnable()
	{
	}

	private void ReloadShopSubtabEnable(string type)
	{
	}

	[AsyncStateMachine(typeof(_003CDevResetDailyShopRefreshCount_003Ed__157))]
	public void DevResetDailyShopRefreshCount()
	{
	}

	public void DevShowPopupPackage(InputField input)
	{
	}

	[AsyncStateMachine(typeof(_003CDevSetUnitBundlePackageUntilAt_003Ed__159))]
	public void DevSetUnitBundlePackageUntilAt()
	{
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Coffee.UIEffects;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardInfoPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public bool processed;

		internal void _003CBuyUnitProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyUnitProcess_003Ed__125 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardInfoPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass125_0 _003C_003E8__1;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CEquipTreasure_003Ed__152 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardInfoPanel _003C_003E4__this;

		public int treasureId;

		private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

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

	[ComponentConnect]
	public RectTransform unitPrefabRoot;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text subnameText;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect("UnitSprite", false)]
	public UIEffect spriteEffect;

	public UnitIllust unitIllust;

	[ComponentConnect]
	public GameObject noUnitBox;

	[SerializeField]
	private Button _prevUnitButton;

	[SerializeField]
	private Button _nextUnitButton;

	[Space(20f)]
	public Button skinButton;

	public Button transformButton;

	public Image transformIcon;

	public Button summonerButton;

	public Image summonerIcon;

	public ConditionalGroup summonerTextConditionalGroup;

	public Image templeIcon;

	public GameObject templeOnEffect;

	public CanvasGroup templeTooltip;

	public Text templeTooltipText;

	public Image regionIcon;

	public Text regionName;

	public Image roleIcon;

	public Text roleName;

	public GameObject genAfterInfoObj;

	public GameObject connectSkillInfoObj;

	public GameObject useTechniqueInfoObj;

	public Text useTechniqueInfoObjName;

	public Text useTechniqueInfoObjDesc;

	[Space(20f)]
	public Button rateComersTooltip;

	[ComponentConnect]
	[Space(20f)]
	public GameObject defaultBox;

	[ComponentConnect]
	public SkinInfoPanel skinBox;

	[ComponentConnect]
	public CardUpgradeEffect cardUpgradeEffect;

	[ComponentConnect]
	public CardUpgradeEffect potentialEffect;

	public CardLevelUpPanel cardLevelUpPanel;

	[Space(20f)]
	[SerializeField]
	private TreasureUIItem _treasureUIItem;

	[SerializeField]
	private List<AccessoryUIItem> _accessoryUIItems;

	[SerializeField]
	private AccessorySynergyBuffIcon _synergyBuffIconPrefab;

	[SerializeField]
	private RectTransform _synergyBuffIconsRoot;

	private List<AccessorySynergyBuffIcon> _synergyBuffIcons;

	[SerializeField]
	private ClickOutsideClose _treasureSkillTooltip;

	[SerializeField]
	private GameObject _treasureSkillIconObj;

	[SerializeField]
	private Image _treasureSkillIcon;

	[SerializeField]
	private Image _treasureSkillBorder;

	[SerializeField]
	private Image _treasureTooltipSkillIcon;

	[SerializeField]
	private Text _treasureTooltipSkillName;

	[SerializeField]
	private Text _treasureTooltipSkillLevel;

	[SerializeField]
	private Text _treasureTooltipSkillDesc;

	[SerializeField]
	private AccessorySynergyToolTip _accessorySynergyToolTip;

	[Space(20f)]
	public Text[] potentialLevel;

	public PotentialButton[] potentialButtons;

	public Button potentialSetToAllButton;

	public GameObject[] potentialLocked;

	public Image[] potentialBorders;

	public Image[] potentialIcons;

	public ClickOutsideClose[] potentialTooltip;

	public Text[] potentialTooltipText;

	public TextFitter[] potentialTooltipTextFitters;

	public Border potentialTooltipBorder;

	public LayoutFitter tier1PotentialTooltipLayoutFitter;

	public Text potentialTooltipLevel;

	[Space(20f)]
	[ComponentConnect]
	public GameObject[] levelBox;

	[ComponentConnect]
	public StatType atkBox;

	[ComponentConnect]
	public StatType matkBox;

	[ComponentConnect]
	public StatType hpBox;

	[ComponentConnect]
	public StatType atkSpeedBox;

	[ComponentConnect]
	public StatType rangeBox;

	[ComponentConnect]
	public StatType moveSpeedBox;

	[ComponentConnect]
	public SkillInfoPanel[] skillInfoPanel;

	public AdvancedCardInfoPanel advancedCardInfoPanel;

	[SerializeField]
	private Button _advancedInfoButton;

	[Space(20f)]
	public Sprite[] atkRangeSprites;

	public Image atkRangeIcon;

	[Space(20f)]
	public ConditionalGroup expGaugeConditionalGroup;

	public ConditionalGroup expGauge_smallConditionalGroup;

	public ConditionalGroup soulGauge_smallConditionalGroup;

	[ComponentConnect]
	public Gauge expGauge;

	public Gauge expGauge_small;

	public Gauge soulGauge_small;

	[Space(20f)]
	public Button expGaugeButton;

	[ComponentConnect]
	public Button upgradeButton;

	[SerializeField]
	private Text upgradeButtonText;

	[SerializeField]
	private Text addUnitContentText;

	[ComponentConnect]
	public Button closeButton;

	[ComponentConnect]
	public ProfileAvatar newUnitPackageButton;

	[ComponentConnect]
	public Text remainPackageTimeText;

	private ShopItemModel _newUnitPackageModel;

	[Space(20f)]
	public RectTransform[] tutorialObjects;

	[NonSerialized]
	public GameObject skinPrefab;

	private string _cachedSkinPrefab;

	[HideInInspector]
	public bool ownCard;

	private bool _loading;

	public Action onClose;

	private bool _isPotentialUpgrade;

	[NonSerialized]
	public bool upgradeButtonActive;

	public ResourceUnit resUnit;

	public CardData cardData;

	private Tween _tooltipTween;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	private PopupManager.PopupInformation _originPopupInformation;

	public bool readyToMockupEquip;

	private bool _requestProcessing;

	public static CardInfoPanel Instance => null;

	public TreasureUIItem treasureUIItem => null;

	public List<AccessoryUIItem> accessoryUIItems => null;

	public TerritoryBonusUnitTooltip territoryBonusUnitTooltip => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ReloadLevelUp()
	{
	}

	public void Reload()
	{
	}

	private void ReloadExp()
	{
	}

	public void Reload(bool levelUp = false, bool tweenExp = true)
	{
	}

	public void ReloadSkin()
	{
	}

	public static Vector2 GetUnitPrefabOffset(ResourceUnit resUnit, ResourceSkin resSkin, SkinInfoPanel.SkinInfoPanelData skinInfoPanelData)
	{
		return default(Vector2);
	}

	public void ReloadIllust()
	{
	}

	public void ReloadUI()
	{
	}

	public void ReloadNewUnitPackage()
	{
	}

	public void Show(CardData cardData, bool own = true, bool popup = true, bool upgradeButtonActive = true)
	{
	}

	public void Hide()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickSkin()
	{
	}

	public void ShowDefaultBox()
	{
	}

	public void OnClickBuy()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyUnitProcess_003Ed__125))]
	public void BuyUnitProcess()
	{
	}

	public void OnClickNewUnitPackage()
	{
	}

	public void Update()
	{
	}

	public void OnClickCardLevelUpPanel()
	{
	}

	public void ShowSkinPrefab(string prefabName)
	{
	}

	public void OnClickTransformButton()
	{
	}

	public void RestoreRootUnit()
	{
	}

	public void OnClickSummonerButton()
	{
	}

	private void ChangeUnit(int transformUnit)
	{
	}

	public void OnClickPotentialSetToAll()
	{
	}

	public void ReloadTier1Potentials()
	{
	}

	private (float, float, float, float, float, int) CalcBaseStat(ResourceUnit resUnit)
	{
		return default((float, float, float, float, float, int));
	}

	private void MappingStat((float hp, float atk, float matk, float attackInterval, float speed, int attackCount) stat, int cardLevel, bool levelUp)
	{
	}

	private void MappingNextStat((float hp, float atk, float matk, float attackInterval, float speed, int attackCount) stat, bool showNext, int cardLevel)
	{
	}

	private void ActivateSwitchButton(Button button, Image icon, int changeTo)
	{
	}

	private int GetSummonerSwitchUnitID()
	{
		return 0;
	}

	public void ShowSpecialUnitToolTip(CanvasGroup infoToolTip)
	{
	}

	public void KillTooltipTween()
	{
	}

	public void ShowTempleTooltip()
	{
	}

	public void ShowRoleOrRegionTooltip(bool showRole)
	{
	}

	public void ShowPotentialTooltip(int idx)
	{
	}

	public void OnClickSkillButton()
	{
	}

	public void OnclickUnitNextOrPrevUnit(int idx)
	{
	}

	private void ReloadTreasure()
	{
	}

	private void ReloadAccessory()
	{
	}

	[AsyncStateMachine(typeof(_003CEquipTreasure_003Ed__152))]
	private void EquipTreasure(int treasureId)
	{
	}

	public void OnclickAdvancedInfo()
	{
	}

	public void ShowStatPopup()
	{
	}
}

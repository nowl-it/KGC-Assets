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

public class CardInfoPanel_Old : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public bool processed;

		public CardInfoPanel_Old _003C_003E4__this;

		internal void _003CBuyUnitProcess_003Eb__0()
		{
		}

		internal void _003CBuyUnitProcess_003Eb__1()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyUnitProcess_003Ed__112 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardInfoPanel_Old _003C_003E4__this;

		private _003C_003Ec__DisplayClass112_0 _003C_003E8__1;

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
	private struct _003COnDevClick_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardInfoPanel_Old _003C_003E4__this;

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

	public static CardInfoPanel Instance;

	[ComponentConnect]
	public RectTransform infoBox;

	[ComponentConnect]
	public SkinInfoPanel skinBox;

	[ComponentConnect]
	public Image unitSprite;

	[ComponentConnect]
	public Text nameText;

	public Border[] subnameTag;

	[ComponentConnect]
	public Text subnameText;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Gauge expGauge;

	[ComponentConnect]
	public Price levelUpPrice;

	[ComponentConnect]
	public Price buyPrice;

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
	public Button closeBlock;

	[ComponentConnect]
	public List<Button> upgradeButton;

	[ComponentConnect]
	public Button unitExpButton;

	[ComponentConnect]
	public Button buyButton;

	public Button expGaugeButton;

	[ComponentConnect]
	public Button closeButton;

	[ComponentConnect]
	public SkillInfoPanel skillInfoPanel;

	[ComponentConnect]
	public GameObject[] levelBox;

	[ComponentConnect]
	public GameObject noUnitBox;

	[ComponentConnect]
	public CanvasGroup main;

	[ComponentConnect]
	public CardUpgradeEffect cardUpgradeEffect;

	[ComponentConnect]
	public CardUpgradeEffect potentialEffect;

	[ComponentConnect("UnitSprite", false)]
	public UIEffect spriteEffect;

	[ComponentConnect]
	public ProfileAvatar newUnitPackageButton;

	[ComponentConnect]
	public Text remainPackageTimeText;

	private ShopItemModel _newUnitPackageModel;

	public Button skinButton;

	public SynergyItem[] synergyItems;

	public Text[] potentialLevel;

	public Text[] potentialOption;

	public PotentialButton[] potentialButtons;

	public CardInfoTab[] tabs;

	public ResourceUnit resUnit;

	public CardData cardData;

	public GameObject unitExpItemCount;

	public Text unitExpItemCountText;

	public Text unitExpButtonText;

	public Text unitExpButtonDesc;

	public Image unitExpButtonIcon;

	public Sprite[] atkRangeSprites;

	public Image atkRangeIcon;

	public CardLevelUpPanel cardLevelUpPanel;

	public Button potentialSetToAllButton;

	public GameObject potentialLocked;

	public GameObject potentialTooltip;

	public Text potentialTooltipText;

	private ConditionalBase[] _closeBlockConditionals;

	public ConditionalGroup expGaugeConditionalGroup;

	public ConditionalGroup expGauge_smallConditionalGroup;

	public ConditionalGroup soulGauge_smallConditionalGroup;

	public ConditionalGroup summonerTextConditionalGroup;

	public Gauge expGauge_small;

	public Gauge soulGauge_small;

	public GameObject skinPrefab;

	private string _cachedSkinPrefab;

	[HideInInspector]
	public bool ownCard;

	private bool _loading;

	public Action onClose;

	public UnitIllust unitIllust;

	public UnitIllust skinPanelIllust;

	public Button[] transformButtons;

	public Image[] transformIcons;

	public Button[] summonerButtons;

	public Image[] summonerIcons;

	public Image templeIcon;

	public GameObject templeOnEffect;

	public CanvasGroup templeTooltip;

	public Text templeTooltipText;

	public Image regionIcon;

	public Text regionName;

	public Image roleIcon;

	public Text roleName;

	public CanvasGroup unitRoleOrRegionTooltip;

	public Text unitRoleOrRegionTooltipText;

	public ConditionalGroup godSkinCond;

	private bool _isPotentialUpgrade;

	public GameObject genAfterInfoObj;

	public GameObject connectSkillInfoObj;

	public GameObject useTechniqueInfoObj;

	public bool upgradeButtonActive;

	private Tween _tooltipTween;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	private bool[] _originTabOverrideSorting;

	public ConditionalBase[] closeBlockConditionals => null;

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

	public void Reload(bool levelUp = false, bool tweenExp = true)
	{
	}

	public void ReloadSkin()
	{
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

	public void OnClickUpgrade()
	{
	}

	[AsyncStateMachine(typeof(_003COnDevClick_003Ed__105))]
	public void OnDevClick()
	{
	}

	public void OnClickUnitExp()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickTab(int idx)
	{
	}

	public void OnClickSkin()
	{
	}

	public void OnClickBuy()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyUnitProcess_003Ed__112))]
	public void BuyUnitProcess()
	{
	}

	private void ShowTabs(bool v)
	{
	}

	private void DisableTabOverrideSorting()
	{
	}

	public void RestoreTabOverrideSorting()
	{
	}

	public void OnClickNewUnitPackage()
	{
	}

	public void Update()
	{
	}

	public void OnClickCardExpPanel()
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

	private void ActivateSwitchButton(Button[] buttons, Image[] icons, int changeTo)
	{
	}

	private int GetSummonerSwitchUnitID()
	{
		return 0;
	}

	public void ShowSpecialUnitToolTip(CanvasGroup infoToolTip)
	{
	}

	public void ShowTempleTooltip()
	{
	}

	public void ShowRoleOrRegionTooltip(bool showRole)
	{
	}
}

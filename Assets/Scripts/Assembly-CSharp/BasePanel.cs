using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BasePanel : MonoBehaviour
{
	public static BasePanel Instance;

	[ComponentConnect]
	public RectTransform bg;

	[ComponentConnect]
	public GameObject normalBox;

	[ComponentConnect]
	public GameObject eventBox;

	[ComponentConnect]
	public GameObject colosseumBox;

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public Image invasionDifficultyObjectImage;

	public ConditionalImage invasionGimmickObject;

	[ComponentConnect]
	public GameObject difficultyObject;

	[ComponentConnect]
	public Text difficultyObjectText;

	[ComponentConnect]
	public GameObject devilObject;

	[ComponentConnect]
	public Text devilObjectText;

	[ComponentConnect]
	public GameObject divinePowerObject;

	[ComponentConnect]
	public Text divinePowerObjectText;

	[ComponentConnect]
	public Text divinePowerAreaText;

	[ComponentConnect]
	public Text stageText;

	[ComponentConnect]
	public ConditionalImage randomHeroButton;

	[ComponentConnect]
	public Text chanceText;

	[ComponentConnect]
	public RectTransform goldArea;

	[ComponentConnect]
	public RectTransform unitCountArea;

	[ComponentConnect]
	public RectTransform divinePowerArea;

	public CanvasGroup divinePowerAreaCanavas;

	[ComponentConnect]
	public CanvasGroup subStartButton;

	[ComponentConnect]
	public ConditionalGroup subStartButtonStateConditionals;

	[ComponentConnect]
	public Text startButtonStageText;

	[ComponentConnect]
	public Text goldEffect;

	[ComponentConnect]
	public RectTransform bottomButtons;

	[ComponentConnect]
	public GameObject ingameMissionObject;

	[ComponentConnect]
	public Text ingameMissionObjectText;

	private int goldEffectCount;

	[ComponentConnect]
	public ConditionalRoot rewardArea;

	[ComponentConnect]
	public GameObject normalArea;

	[ComponentConnect]
	public Image otherRewardObject;

	[ComponentConnect]
	public RectTransform nextGold;

	[ComponentConnect]
	public Text nextGoldText;

	[ComponentConnect]
	public GameObject pvpDeckRecordArea;

	[ComponentConnect]
	public Text pvpNextGoldText;

	[ComponentConnect]
	public Button pvpDeckRecordInfoButton;

	[ComponentConnect]
	public GameObject pvpDeckRecordInfo;

	[ComponentConnect]
	public Text pvpDeckRecordInfoText;

	[ComponentConnect]
	public Border eliteInfo;

	[ComponentConnect]
	public Text eliteInfoTitle;

	[ComponentConnect]
	public Text eliteInfoDesc;

	[ComponentConnect]
	public Border difficultyInfo;

	[ComponentConnect]
	public Text difficultyInfoTitle;

	[ComponentConnect]
	public Text difficultyInfoDesc;

	[ComponentConnect]
	public Border devilInfo;

	[ComponentConnect]
	public Text devilInfoTitle;

	[ComponentConnect]
	public Text devilInfoDesc;

	[ComponentConnect]
	public Border divinePowerInfo;

	[ComponentConnect]
	public Text divinePowerInfoTitle;

	[ComponentConnect]
	public Text divinePowerInfoDesc;

	[ComponentConnect]
	public Text eventStageText;

	[ComponentConnect]
	public GameObject eventGoldArea;

	[ComponentConnect]
	public Text eventGoldText;

	[ComponentConnect]
	public Text randomItemCostText;

	[ComponentConnect]
	public Border ingameMissionInfo;

	[ComponentConnect]
	public Text ingameMissionInfoDesc;

	public ConditionalGroup missionCheckBoxCond;

	public GameObject arenaObject;

	public GameObject arenaInfo;

	public Image seasonalEventObject;

	public GameObject seasonalEventInfo;

	public Text seasonalEventInfoTitle;

	public Text seasonalEventInfoDesc;

	public GameObject randomItemLimitArea;

	public GameObject freeMerchantRefreshCountArea;

	public Text randomItemLimitText;

	public Text freeMerchantRefreshCountText;

	public Image[] lifeIcons;

	public RectTransform stageIconGroup;

	public Image[] stageIcons;

	public Image[] stageClearMarks;

	public RectTransform playerPawn;

	public RectTransform[] midBossPawn;

	public RectTransform finalBossPawn;

	public RectTransform colosseumStageIconGroup;

	public Image[] colosseumStageIcons;

	public Image[] colosseumStageClearMarks;

	public RectTransform colosseumPlayerPawn;

	public RectTransform[] colosseumMidBossPawn;

	public RectTransform colosseumFinalBossPawn;

	[SerializeField]
	private ColosseumInvadePointIndicator[] _colosseumInvadePointIndicators;

	public GameObject colosseumBackToMyBattleButton;

	public Button eventCraftButton;

	public Button eventMerchantButton;

	private PopupPanel _progressTooltipPanel;

	private InvasionGimmickTooltipPanel _invasionGimmickTooltipPanel;

	private int _baseStage;

	private int _currentStage;

	private Sprite _battleMark;

	private Sprite _itemRewardMark;

	private Sprite _randomItemMark;

	private Sprite _shopMark;

	private bool _inited;

	private Tweener _subStartButtonTween;

	private bool _subStartAlphaHold;

	private static Vector3 _midBossLeftPos;

	private static Vector3 _midBossRightPos;

	private static Vector3 _finalBossPos;

	private float _lastCallTime;

	[Space(20f)]
	public BabelBasePanelBox babelBox;

	public PopupPanel progressTooltipPanel => null;

	public InvasionGimmickTooltipPanel invasionGimmickTooltipPanel => null;

	public void Init(bool force = false)
	{
	}

	public void Awake()
	{
	}

	public void Reload()
	{
	}

	public void ReloadRandomItemLimit()
	{
	}

	public void ReloadFreeMerchantCount()
	{
	}

	public void SetLife(int life)
	{
	}

	public void SetInvasionDifficulty(int difficulty)
	{
	}

	public void OnClickElite()
	{
	}

	public void SetDifficulty(int difficulty)
	{
	}

	public void OnClickDifficulty()
	{
	}

	public void SetDevil(int turn, DevilPanel.Condition condition)
	{
	}

	public void OnClickDevil()
	{
	}

	public void SetDivinePower(float divinePower)
	{
	}

	public void OnClickDivinePower()
	{
	}

	public void OnClickIngameMission()
	{
	}

	public void OnClickDisplayMissionFailWarning()
	{
	}

	public void OnClickCloseIngameMission()
	{
	}

	public void HidePopup()
	{
	}

	public void OnClickPvPDeckSetInfo()
	{
	}

	public void SetStage(int stage)
	{
	}

	public void SetRankingStage(string themeName)
	{
	}

	public void SetEventStage(string themeName)
	{
	}

	public void ReloadStageMap()
	{
	}

	public void SetReward(ResourceStage resStage, bool showTween = true)
	{
	}

	public void SetSummonChance(int count)
	{
	}

	public void SetPositionRatio(float ratio)
	{
	}

	public void ShowSubStartButton(bool v)
	{
	}

	public void ShowAddGold(int gold)
	{
	}

	private void ShowAddGoldInner(int gold, Text goldEffectText = null)
	{
	}

	public void OnClickRandomItemOpen()
	{
	}

	public void OnClickMerchantOpen()
	{
	}

	public void SetEventGold(int gold)
	{
	}

	public void SetArena()
	{
	}

	public void OnClickArenaObject()
	{
	}

	public void SetSeasonalEvent()
	{
	}

	public void OnClickSeasonalEventObject()
	{
	}

	public void HandleInvadePointChanged(int invadePoint, bool showEffect, bool showOverPoint = false, float baseEffectDelay = 1.5f)
	{
	}

	public void OnClickProgressBar()
	{
	}

	public void OnClickInvasionGimmickObject()
	{
	}

	public void InitializeBabelBasePanel()
	{
	}
}

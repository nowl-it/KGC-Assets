using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelectPanel : MonoBehaviour, IClosable
{
	private enum StartButtonSprite
	{
		Invasion = 0,
		Event = 1,
		SeasonalEvent = 2
	}

	[SerializeField]
	private TextFitter _themeNumText;

	[SerializeField]
	private Text _themeNameText;

	[SerializeField]
	private GameObject _expeditionTag;

	[SerializeField]
	private InvasionDifficultyBar _invasionDifficultyBar;

	[SerializeField]
	private GameObject _modeDesc;

	[SerializeField]
	private Text _modeDescText;

	[SerializeField]
	private DeckSlotToggle _deckSlotToggle;

	[Header("Start Button")]
	[SerializeField]
	private ConditionalImage _startButtonSpriteConditional;

	[SerializeField]
	private ConditionalGroup _startCostConditionals;

	[SerializeField]
	private ConditionalGroup _startButtonLockedConditionals;

	[SerializeField]
	private TextFitter _startButtonTextFitter;

	[SerializeField]
	private Text _startButtonCostText;

	[SerializeField]
	private Image _startButtonCostIcon;

	[SerializeField]
	private Text[] _startButtonCurrencyText;

	[SerializeField]
	private Image[] _startButtonCurrencyIcon;

	[SerializeField]
	private Text _startButtonUntilAtText;

	[SerializeField]
	private GameObject _eventDifficultyButton;

	[SerializeField]
	private Image _prevThemeIcon;

	[SerializeField]
	private Image _nextThemeIcon;

	[SerializeField]
	private Button _prevThemeButton;

	[SerializeField]
	private Button _nextThemeButton;

	[SerializeField]
	private ConditionalSetActive _newThemeBadge;

	[SerializeField]
	private Image _themeLock;

	[SerializeField]
	private Text _themeLockText;

	[SerializeField]
	private Text _commingSoonText;

	[SerializeField]
	private GameObject _rankingButton;

	[SerializeField]
	private TabManager _themeTabManager;

	[SerializeField]
	private Image _hardModeLock;

	[SerializeField]
	private FlexibleUIElements _rewardItemElements;

	[SerializeField]
	private Border _rewardAreaBorder;

	[SerializeField]
	private TextFitter _rewardDescTextFitter;

	[SerializeField]
	private Border _rewardDescBorder;

	[SerializeField]
	private DeckPreviewPanel _deckPreviewPanel;

	[SerializeField]
	private GameObject _themeBox;

	[SerializeField]
	private ClanGoldBonus _totalGoldBonus;

	[SerializeField]
	private GameObject _unitBundlePackageButton;

	[SerializeField]
	private GameObject _closeButton;

	[SerializeField]
	private GameObject _invasionRewardButton;

	[SerializeField]
	private Text _invasionRewardButtonBadgeText;

	public Button invasionGimmickButton;

	public InvasionGimmickTooltipPanel invasionGimmickTooltipPanel;

	[SerializeField]
	private GameObject _foodBooster;

	[SerializeField]
	private Image _foodBoosterCostIcon;

	[SerializeField]
	private Text _foodBoosterCostText;

	[SerializeField]
	private Text _foodBoosterRewardText;

	[SerializeField]
	private GameObject _foodBoosterNotCleared;

	[SerializeField]
	private Button _foodBoosterUpButton;

	[SerializeField]
	private Button _foodBoosterDownButton;

	[SerializeField]
	private GameObject _invasionDifficultyTooltipButton;

	[SerializeField]
	[Header("GameStartPopUp")]
	private Image _themeBG;

	[SerializeField]
	private Image _themeObject;

	[SerializeField]
	private Image _themeUnit;

	[SerializeField]
	private RectMask2D _themeUnitMask;

	[SerializeField]
	private Button _gameStartButton;

	[SerializeField]
	private Button _gameSkipButton;

	[SerializeField]
	private Text[] _gameSkipFoodCosts;

	[SerializeField]
	private GameSkipPanel _gameSkipPanel;

	[SerializeField]
	private GameObject _gameSkipPanelToggle;

	[SerializeField]
	private Text _gameSkipPanelToggleText;

	[SerializeField]
	private GameObject _addDifficultyUnlockDesc;

	private EventModeDifficultyPopup _difficultyPopup;

	private RankingPanel _rankingPanel;

	private InvasionRewardPanel _invasionRewardPanel;

	private InvasionDifficultyTooltipPanel _invasionDifficultyTooltip;

	private int _newTheme;

	private int _currentTheme;

	private ResourceTheme _resTheme;

	private int[] _eliteLevels;

	private List<int> _themes;

	private int[] _themeIndex;

	private int _themeSeason;

	private bool _isEventMode;

	private bool _isHardMode;

	private bool _isSeasonalEventMode;

	private Vector3 _gameStartPopupCloseButtonPos;

	private Vector3 _seasonalEventGameStartButtonPos;

	private Vector3 _gameStartPopupThemeBoxPos;

	public InvasionDifficultyBar invasionDifficultyBar => null;

	public DeckSlotToggle deckSlotToggle => null;

	public Button nextThemeButton => null;

	public int deckCombatPower => 0;

	public GameObject themeBox => null;

	public GameObject invasionRewardButton => null;

	public EventModeDifficultyPopup difficultyPopup => null;

	public RankingPanel rankingPanel => null;

	public InvasionRewardPanel invasionRewardPanel => null;

	public InvasionDifficultyTooltipPanel invasionDifficultyTooltip => null;

	public int currentTheme => 0;

	public int[] eliteLevels => null;

	public int themeSeason => 0;

	private int _currentThemeIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool _isInvasion => false;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show()
	{
	}

	public void ReloadIsHardMode()
	{
	}

	public void ReloadThemeInfo()
	{
	}

	private bool IsThemeAvailable(ResourceTheme resTheme, out string bgName)
	{
		bgName = null;
		return false;
	}

	public void ReloadStartButtonAndFoodBooster()
	{
	}

	private bool ClearedDefaultDifficulty()
	{
		return false;
	}

	public bool CanDifficulty(int difficulty, bool showMessage = true)
	{
		return false;
	}

	private bool IsDifficultyLocked()
	{
		return false;
	}

	private bool IsInvasionDifficultyCleared(int difficulty, int theme = -1)
	{
		return false;
	}

	private bool IsThemeLocked(ResourceTheme resTheme)
	{
		return false;
	}

	public void SetEliteLevel(int id, int level)
	{
	}

	public void SetEliteLevels(int[] eliteLevels)
	{
	}

	private void ReloadEventDifficultyButton()
	{
	}

	public void OnClickEventDifficultyButton()
	{
	}

	public void ReloadPlayCounts()
	{
	}

	public void OnClickPrevTheme()
	{
	}

	public void OnClickNextTheme()
	{
	}

	public void OnClickFoodBoosterUp()
	{
	}

	public void OnClickFoodBoosterDown()
	{
	}

	public void OnSelectTheme(int id, int difficulty = -1)
	{
	}

	private void OnSelectInvasionTheme(ResourceTheme resTheme, int difficulty = -1)
	{
	}

	public void ReloadInvasionRewardBadge(int receivableRewardCount)
	{
	}

	public void ReloadThemeReward()
	{
	}

	public void ReloadDeck()
	{
	}

	public int ReloadNewThemeBadge()
	{
		return 0;
	}

	public void ReloadInvasionRecords()
	{
	}

	public void SwitchMode(bool eventMode, bool checkForGameSkip = true, bool init = false)
	{
	}

	public void SwitchSeasonalEventMode(int idx)
	{
	}

	public void OnClickRanking()
	{
	}

	public void OnClickSelectHardThemeTab(int idx)
	{
	}

	public bool OpenInvasionTheme(int season)
	{
		return false;
	}

	public static int GetLastPlayedInvasionTheme(int season)
	{
		return 0;
	}

	public void OpenEventMode(int idx)
	{
	}

	public void OpenSeasonEventMode(int idx)
	{
	}

	public void OnClickGameStart()
	{
	}

	public void OnClickInvasionRewardButton()
	{
	}

	public void OnClickGameSkipPanelToggle()
	{
	}

	public void ReloadGameSkipPanel(bool keepValue)
	{
	}

	private void OnGameSkipCountChanged()
	{
	}

	public void OnClickGameSkip()
	{
	}

	public void OnClickInvasionDifficultyTooltip()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickInvasionGimmick()
	{
	}

	private void ReloadDeckPreviewPanelActive(bool isSeasonalQuizMode)
	{
	}
}

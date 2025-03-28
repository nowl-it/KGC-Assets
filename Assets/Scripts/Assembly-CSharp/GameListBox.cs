using UnityEngine;
using UnityEngine.UI;

public class GameListBox : MonoBehaviour, IClosable
{
	public static GameListBox Instance;

	public LayoutFitter[] contentLayoutFitters;

	public ScrollRect beginnerScrollRect;

	public ScrollRect invasionScrollRect;

	public ScrollRect seasonScrollRect;

	public TabManager categoryTabManager;

	public GameObject hardModeShopButton;

	public Button[] lobbyThemeButtons;

	public Text[] currentFood_mode;

	public Image[] lobbyThemeBG;

	public Image[] lobbyThemeObject;

	public Image[] lobbyThemeUnit;

	public Image[] lobbyLock;

	[SerializeField]
	private Text _invasionRewardButtonBadgeText;

	public Button eventButton;

	public GameObject eventCountBox;

	public Text currentFlagText_mode;

	public Text flagChargedAt;

	public Image eventModeBG;

	public Image eventModeUnit;

	public GameObject eventLock;

	public Button seasonalEventButton;

	public GameObject seasonalEventCountBox;

	public Text currentSeasonalEventCount_mode;

	public Text seasonEventFlagChargedAt;

	public Image seasonalEventModeBG;

	public Image seasonalEventUnit;

	public Text seasonalEventModeText;

	public GameObject seasonalEventLock;

	public Button babelButton;

	public Image babelBG;

	public Image babelUnit;

	public GameObject babelLock;

	public Button rogueLikeButton;

	public Text currentRogueLikeFood_mode;

	public GameObject rogueLikeLock;

	public GameObject rogueLikeFoodBox;

	public Image rogueLikeBG;

	public Image rogueLikeUnit;

	private bool _useBeginnerScroll => false;

	public static void SetSingleton(GameListBox instance)
	{
	}

	private void ReloadScroll()
	{
	}

	public void Show()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void Reload()
	{
	}

	public void ReloadPlayCounts()
	{
	}

	public void ReloadInvasionRewardBadge()
	{
	}

	public void OnClickThemeButton(int season)
	{
	}

	public void OnClickEventButton()
	{
	}

	public void OnClickSeasonalEventButton()
	{
	}

	public void OnClickBabelButton()
	{
	}

	public void OnClickRogueLikeButton()
	{
	}

	public void OnClickHardModeShop()
	{
	}

	public void OnClickInvasionRewardButton()
	{
	}

	public void OpenAndFocusEvent()
	{
	}

	public void OpenAndFocusSeasonalEvent()
	{
	}
}

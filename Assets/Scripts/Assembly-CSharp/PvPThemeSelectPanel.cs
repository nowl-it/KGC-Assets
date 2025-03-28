using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvPThemeSelectPanel : MonoBehaviour
{
	private static PvPThemeSelectPanel _instance;

	private LeagueHallOfFamePanel _leagueHallOfFamePanel;

	[SerializeField]
	private GameObject _themeItem;

	[SerializeField]
	private GameObject _pvpPanel;

	[SerializeField]
	private GameObject _colosseumPanel;

	[SerializeField]
	private Text _leagueTimeLeftText;

	[SerializeField]
	private FlexibleUIElements _bannedIconElements;

	private readonly List<(int themeId, PvPThemeSelectPanelItem button)> _buttonsByThemeId;

	private DateTime _leagueUntilAt;

	private DateTime _nextLeagueStartAt;

	private DateTime _lastUpdateTime;

	public static PvPThemeSelectPanel Instance => null;

	public LeagueHallOfFamePanel leagueHallOfFamePanel => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	public void Reload()
	{
	}

	public void ReloadRedDots()
	{
	}

	private void ReloadLeagueUntilAt()
	{
	}

	private void Update()
	{
	}

	private PvPThemeSelectPanelItem AddTheme(ResourceTheme resTheme, int season, GameObject panel)
	{
		return null;
	}

	public void ClickTheme(int themeId)
	{
	}

	private void UpdateSeasonTimeLeftText()
	{
	}

	public static string GetSeasonTimeLeftText(DateTime untilAt, DateTime nextStartAt)
	{
		return null;
	}

	public void ShowBalloon(int themeId, bool show, string type)
	{
	}

	public void ReloadNewBalloon()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}

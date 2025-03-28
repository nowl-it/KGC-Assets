using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

public class PvPThemeSelectPanelItem : MonoBehaviour
{
	[SerializeField]
	private Image _mapBGImage;

	[SerializeField]
	private Image _themeImage;

	[SerializeField]
	private GameObject _tiersRoot;

	[SerializeField]
	private Image[] _tierIconImages;

	[SerializeField]
	private Image[] _tierStarImages;

	[SerializeField]
	private Image[] _noScoreYetObjects;

	[SerializeField]
	private Text _firstSemiSeasonTierTitleText;

	[SerializeField]
	private Text _themeNameText;

	[SerializeField]
	private TextFitter _themeNameTextFitter;

	[SerializeField]
	private List<UIGradient> _gradients;

	[SerializeField]
	private Text _lockText;

	[SerializeField]
	private GameObject _missionClearedBalloon;

	[SerializeField]
	private GameObject _newBalloon;

	[SerializeField]
	private ImageTextPair _redDot;

	private GameObject _panel;

	private ResourceTheme _resTheme;

	public void Set(ResourceTheme resTheme, int season, GameObject panel)
	{
	}

	public void ReloadRedDot()
	{
	}

	public void SetTier(List<LeagueContentScoreData> scoreDatas, int curSemiSeason, DateTime thisSemiSeasonStartAt, Func<int, int, IResourceRankTier> getResTierFunc)
	{
	}

	public void ShowMissionClearedBalloon(bool show)
	{
	}

	public void ShowNewBalloon(bool show)
	{
	}

	public void OnClick()
	{
	}
}

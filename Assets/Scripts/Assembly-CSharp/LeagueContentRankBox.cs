using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class LeagueContentRankBox : MonoBehaviour
{
	[SerializeField]
	private Text _seasonText;

	[SerializeField]
	private Text _seasonUntilAtText;

	[SerializeField]
	private Text _emptyText;

	[SerializeField]
	private GameObject _scoreObjectsRoot;

	[SerializeField]
	private Text[] _scoreTexts;

	[SerializeField]
	private Image[] _tierIcons;

	[SerializeField]
	private Image[] _starIcons;

	[SerializeField]
	private Text[] _tierTexts;

	[SerializeField]
	private Text _nextSemiSeasonStartAtText;

	[SerializeField]
	private GameObject _bestScoreObject;

	[SerializeField]
	private GameObject _dormantObj;

	[SerializeField]
	private Text _dormantText;

	private DateTime _seasonUntilAt;

	private DateTime _thisSemiSeasonStartAt;

	private DateTime _nextSemiSeasonStartAt;

	private bool _semiSeasonAvailable;

	public void SetDefault()
	{
	}

	public void Set<Tier>(string seasonFormat, int season, int curSemiSeason, List<LeagueContentScoreData> scoreDatas, DateTime seasonUntilAt, DateTime thisSemiSeasonStartAt, DateTime nextSemiSeasonStartAt, Func<int, int, Tier> getResTierFunc) where Tier : IResourceRankTier
	{
	}

	public void ShowDormantObject(bool show)
	{
	}

	public void SetDormantText(string text)
	{
	}

	public void SetCurrentScoreText(int score)
	{
	}

	public string GetSeasonUntilAtText()
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateTimeTexts()
	{
	}
}

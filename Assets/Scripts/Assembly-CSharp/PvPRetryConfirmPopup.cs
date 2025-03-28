using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvPRetryConfirmPopup : Popup
{
	public Text titleText;

	public Text remainFree;

	public Price cost;

	public int cashPrice;

	public DeckSlotToggle deckSlotToggle;

	public DeckPreviewPanel myDeckPanel;

	public RectTransform penaltyBox;

	public RectTransform myDeck;

	public RectTransform startButton;

	public List<GameObject> retryDescObjs;

	[SerializeField]
	private List<ConditionalImage> _themeIcons;

	[SerializeField]
	private List<Text> _themeNameTexts;

	[SerializeField]
	private TextFitter[] _penaltyTextFitters;

	[Space(20f)]
	[Header("그랜드 아레나 관련")]
	[SerializeField]
	private GameObject _seasonBuffObj;

	[SerializeField]
	private List<ImageTextPair> _seasonBuffs;

	[SerializeField]
	private GameObject _chapterInfoObj;

	[SerializeField]
	private Text _deckRecordDescText;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(string title, string message, bool forceFreeRetry, bool showPenaltyBox, Action<bool> callback = null, bool isGrandArena = false, (int, int) themeAndDifficulty = default((int, int)))
	{
	}

	public void ReloadDeck()
	{
	}

	public void OnClickBattle()
	{
	}

	public void OnClickBonusUnitTooltip(int index)
	{
	}
}

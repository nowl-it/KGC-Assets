using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventModeDifficultyPopup : MonoBehaviour, IClosable
{
	public List<ImageTextPair> textPairs;

	public Text currentDifficultyText;

	public ConditionalRoot condRoot;

	public GameObject prevDiffButton;

	public GameObject nextDiffButton;

	public Text themeNameText;

	public ResourceTheme _theme;

	public int _currentDifficulty;

	public int _currentThemeMaxDifficulty;

	public Text difficultyDescText;

	public Text rewardText;

	public Text missionText;

	public GameObject difficultyDesc;

	public GameObject modeDesc;

	public GameObject missionDesc;

	public void Show(int theme)
	{
	}

	public void Refresh()
	{
	}

	public void OnClickPrevDiffButton()
	{
	}

	public void OnClickNextDiffButton()
	{
	}

	private void RefreshDifficultyText()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickChangeDifficult()
	{
	}

	public static (int, int) GetMode103UnitLevelAndPotentialTier(int cardLevel, int difficulty)
	{
		return default((int, int));
	}
}

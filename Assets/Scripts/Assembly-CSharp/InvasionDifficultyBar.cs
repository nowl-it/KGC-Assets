using UnityEngine;
using UnityEngine.UI;

public class InvasionDifficultyBar : MonoBehaviour
{
	[SerializeField]
	private Text _selectedDifficultyNameText;

	[SerializeField]
	private TextFitter _selectedDifficultyRoundText;

	[SerializeField]
	private Border _selectedDifficultyGradationBorder;

	[SerializeField]
	private Text _combatPowerText;

	[SerializeField]
	private FlexibleUIElements _difficultyItemElements;

	[SerializeField]
	private GameObject _unlockNextChapterText;

	[SerializeField]
	private Image _selectedDifficultyItemEffect;

	[SerializeField]
	private FlexibleUIElements _difficultyTooltipTextElements;

	private ResourceTheme _resTheme;

	private int _currentDifficulty;

	public int currentDifficulty => 0;

	private void OnDisable()
	{
	}

	public void SetTheme(ResourceTheme resTheme, bool isThemeLocked, int difficulty = -1)
	{
	}

	public void ReloadCombatPower()
	{
	}

	public void SetDifficulty(int difficulty)
	{
	}

	public void SetDifficultyToZero()
	{
	}

	private int GetUnlockedDifficulty()
	{
		return 0;
	}

	public void ShowDifficultyTooltip(int difficulty)
	{
	}

	public Button GetDifficultyButton(int difficulty)
	{
		return null;
	}

	public static int[] GetEliteLevelsByDifficulty(int difficulty)
	{
		return null;
	}

	public static string GetDifficultyName(int difficulty)
	{
		return null;
	}

	public static int GetDifficultyRewardPer(int difficulty)
	{
		return 0;
	}
}

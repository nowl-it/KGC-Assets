using UnityEngine;
using UnityEngine.UI;

public class InvasionDifficultyTooltipItem : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _difficultyText;

	[SerializeField]
	private FlexibleUIElements _difficultyTooltipTextElements;

	public void Set(int difficulty)
	{
	}

	private void SetTooltip(int difficulty)
	{
	}
}

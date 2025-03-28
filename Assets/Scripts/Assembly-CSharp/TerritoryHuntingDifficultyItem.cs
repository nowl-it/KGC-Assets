using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingDifficultyItem : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Text _difficultyText;

	[SerializeField]
	private Text _recommendedLevelText;

	[SerializeField]
	private GameObject _selectedObject;

	[SerializeField]
	private GameObject _unselectedObject;

	[SerializeField]
	private ConditionalGroup _difficultyConditional;

	private int _difficulty;

	public void Set(int rootResHuntingId, int difficulty)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void OnClick()
	{
	}
}

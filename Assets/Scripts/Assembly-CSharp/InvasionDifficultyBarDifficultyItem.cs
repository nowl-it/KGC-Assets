using UnityEngine;
using UnityEngine.UI;

public class InvasionDifficultyBarDifficultyItem : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _difficultyText;

	[SerializeField]
	private GameObject _lockObject;

	[SerializeField]
	private GameObject _selectedObject;

	[SerializeField]
	private GameObject _unselectedObject;

	private int _difficulty;

	private bool _locked;

	public void Set(int difficulty)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	public void SetLocked(bool locked)
	{
	}

	public void OnClick()
	{
	}
}

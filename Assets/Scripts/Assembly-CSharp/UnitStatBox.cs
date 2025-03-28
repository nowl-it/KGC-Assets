using UnityEngine;
using UnityEngine.UI;

public class UnitStatBox : MonoBehaviour
{
	[SerializeField]
	private StatType _hpBox;

	[SerializeField]
	private StatType _atkBox;

	[SerializeField]
	private StatType _matkBox;

	[SerializeField]
	private StatType _atkSpeedBox;

	[SerializeField]
	private StatType _moveSpeedBox;

	[SerializeField]
	private StatType _rangeBox;

	[SerializeField]
	private Image _atkRangeIcon;

	[SerializeField]
	private Sprite[] _atkRangeSprites;

	private ResourceUnit _resUnit;

	private bool _isRogueLike;

	public void SetStatBox(CardData cardData, int level = 1, bool force = false, bool isRogueLike = false)
	{
	}

	public void SetStatWithNextLevel(CardData cardData, int nextLevel, bool force = false, bool isRogueLike = false)
	{
	}

	private void ShowNextValue(int level)
	{
	}
}

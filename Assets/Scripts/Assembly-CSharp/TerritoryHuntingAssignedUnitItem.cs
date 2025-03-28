using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingAssignedUnitItem : MonoBehaviour
{
	[SerializeField]
	private Image _unitPortrait;

	[SerializeField]
	[CanBeNull]
	private ConditionalImage _levelBox;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Image _regionIcon;

	public void Set(CardData cardData)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;

public class LevelSyncingUnitInfo : MonoBehaviour
{
	[SerializeField]
	private Image _bg;

	[SerializeField]
	private Image _illust;

	[SerializeField]
	private Image[] _lines;

	public TerritoryDraggableUnitCard unitCard;

	public void SetAsMin()
	{
	}

	public void Set(CardData cardData, IDraggableCardBaseHandler<CardData> handler)
	{
	}
}

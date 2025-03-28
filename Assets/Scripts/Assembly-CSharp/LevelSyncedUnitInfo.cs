using UnityEngine;

public class LevelSyncedUnitInfo : MonoBehaviour
{
	public TerritoryDraggableUnitCard before;

	public TerritoryDraggableUnitCard after;

	public void Set(CardData cardData, int nextLevel, int nextPotential, IDraggableCardBaseHandler<CardData> handler, bool blockDrag = false)
	{
	}
}

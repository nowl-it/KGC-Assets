using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public interface IDraggableDeck
{
	void SetDraggingCard(DraggableUnitCard card);

	void EquipCard(int idx, UnitCard card);

	void UnEquipCard(UnitCard card);

	void SwapDeckCard(UnitCard card1, UnitCard card2);

	void SaveDeck();

	RectTransform GetDeckLayout();

	UnitCard FindCardFromCurrentDeck(Func<UnitCard, bool> func);

	int[] GetCurrentDeck();

	Image GetDeckBgObject(int index)
	{
		return null;
	}

	int GetIndexFromCurrentDeck(UnitCard card);

	Image GetLayoutBgObject(int index)
	{
		return null;
	}

	int GetIndexFromCurrentLayout(UnitCard card)
	{
		return 0;
	}

	void EquipArtifact(int idx, ArtifactModel artifact);

	void SetDraggingArtifact(DraggableArtifactCard card);

	DraggableArtifactCard[] GetEquippedArtifactCards();

	int GetArtifactOptionSum(int unitPos, string type);

	void CheckBeforeEquipCard(int idx, UnitCard card, Action success, Action fail)
	{
	}

	bool HasToCheckBeforeEquipCard()
	{
		return false;
	}

	bool CanEquipCard(int idx, UnitCard card)
	{
		return false;
	}
}

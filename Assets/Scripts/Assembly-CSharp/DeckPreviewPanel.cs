using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class DeckPreviewPanel : MonoBehaviour
{
	[SerializeField]
	protected CardPreviewItem[] cardPreviewItems;

	[SerializeField]
	protected AltarPreviewItem[] altarPreviewItems;

	[SerializeField]
	protected ArtifactCraftSlot[] artifactSlots;

	[SerializeField]
	protected TerritoryStatBuffDisplayer territoryStatBuffDisplayer;

	[SerializeField]
	protected DeckCombatPower _combatPower;

	[SerializeField]
	protected Text _deckSlotNameText;

	[SerializeField]
	protected Border _deckSlotBorder;

	public int combatPower { get; protected set; }

	public void Show(List<CardData> cards, List<ArtifactModel> artifacts, List<BuildingData> buildings, int[] potentials, bool showArtifactLocked)
	{
	}

	public void Show(CardInfo[] cards, List<ArtifactModel> artifacts, List<BuildingData> buildings, int[] potentials, bool showArtifactLocked)
	{
	}

	public void Show(ClanRaidCardInfo[] cards, List<ArtifactModel> artifacts, int[] buildings, int[] potentials, bool showArtifactLocked, bool[] blocked = null, bool adjustArtifact = true)
	{
	}

	protected void ShowArtifacts(List<ArtifactModel> artifacts, bool showArtifactLocked)
	{
	}

	protected void ShowBuildings(List<BuildingData> buildings)
	{
	}

	public void ShowDefault(bool showArtifactLocked)
	{
	}

	public void ShowTerritoryStatBuff(float[] statBuffs = null)
	{
	}

	public void ShowTerritoryStatBuffByInt(int[] statBuffs)
	{
	}

	public void SetDeckNameText(int deckIdx)
	{
	}

	public void OnClickArtifactLevelLocked(int idx)
	{
	}
}

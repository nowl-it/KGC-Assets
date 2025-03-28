using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;

public class PvPEnemyInfoPanel : MonoBehaviour
{
	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public RectTransform myDeck;

	[ComponentConnect]
	public PlayerProfile playerProfile;

	[ComponentConnect]
	public UnitBalanceInfoPanel pvpEnemyBalancePanel;

	public CardPreviewItem[] cardPreviewItems;

	public AltarPreviewItem[] altarPreviewItems;

	public ArtifactCraftSlot[] artifactSlots;

	public TerritoryStatBuffDisplayer territoryStatBuffDisplayer;

	public DeckCombatPower deckCombatPower;

	public Transform resultLayout;

	public GameObject pvpResultItemPrefab;

	private List<PvPResultItem> _resultItems;

	private bool _isSplash;

	public void InitPresets(List<ResourcePvpEnemyPreset> pvpStages)
	{
	}

	private void ShowImpl(bool splash, bool showTerritoryStatBuffs)
	{
	}

	public void Show(ResourcePvpEnemyPreset resPvpEnemyPreset, List<(int card, int level, int potentialTier)> enemyDeck, List<BuildingData> buildingData, List<ArtifactModel> artifacts, bool splash = true)
	{
	}

	public void ShowColosseumPlayerDeck(ColosseumPlayerDataResponseModel.ColosseumPlayerData data)
	{
	}

	public void RegisterResult(int id, PvPResultItem.State state)
	{
	}

	public void OnClickClose()
	{
	}
}

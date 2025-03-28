using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class DeckCombatPower : MonoBehaviour
{
	[SerializeField]
	public Text _text;

	[SerializeField]
	public TextFitter _textFitter;

	[SerializeField]
	public Border _border;

	public int SetDefault()
	{
		return 0;
	}

	public int Set(List<CardData> cards, List<ArtifactModel> artifacts, List<BuildingData> buildings)
	{
		return 0;
	}

	public int Set(CardInfo[] cards, List<ArtifactModel> artifacts, List<BuildingData> buildings)
	{
		return 0;
	}

	public int Set(CardInfo[] cards, List<ArtifactModel> artifacts, int[] buildings)
	{
		return 0;
	}

	public int Set(ClanRaidCardInfo[] cards, List<ArtifactModel> artifacts, int[] buildings)
	{
		return 0;
	}

	public int Set(List<(int card, int level, int potentialTier)> cards, List<ArtifactModel> artifacts, List<BuildingData> buildings)
	{
		return 0;
	}

	private void Fit()
	{
	}
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDisplayer : MonoBehaviour
{
	private enum StatType
	{
		Atk = 0,
		AtkPer = 1,
		MAtk = 2,
		AtkSpeed = 3,
		Shield = 4,
		Hp = 5,
		HpPer = 6,
		Speed = 7,
		RogueLikeArtifactBuilding_None = 8,
		RogueLikeArtifactBuilding_100 = 9,
		RogueLikeArtifactBuilding_101 = 10,
		RogueLikeArtifactBuilding_102 = 11,
		RogueLikeArtifactBuilding_103 = 12,
		RogueLikeArtifactBuilding_104 = 13,
		RogueLikeArtifactBuilding_105 = 14,
		RogueLikeArtifactBuilding_106 = 15
	}

	public struct StatItem
	{
		public Image icon;

		public Text text;

		public AwesomeOutline outline;

		public TextFitter textFitter;

		public StatItem(GameObject go)
		{
			icon = null;
			text = null;
			outline = null;
			textFitter = null;
		}
	}

	[SerializeField]
	private GameObject _statPrefab;

	[SerializeField]
	private Transform _root;

	private List<StatItem> _stats;

	public void SetUnit(ResourceUnit resUnit, int level, bool showSpeed)
	{
	}

	public void SetItem(Item item)
	{
	}

	public void SetRogueLikeArtifact(RogueLikeArtifactModel artifact)
	{
	}

	private void Clear()
	{
	}

	private void AddStat(StatType type, int value, bool isPercent, int bonus = 0)
	{
	}
}

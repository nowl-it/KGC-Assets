using System.Collections.Generic;
using UnityEngine;

public class GachaUnitPercentageTable : MonoBehaviour, IClosable
{
	private class UnitAndRatePair
	{
		public ResourceUnit resUnit;

		public ResourceInventoryItem resInventoryItem;

		public float rate;

		public UnitAndRatePair(ResourceUnit resUnit, float rate)
		{
		}

		public UnitAndRatePair(ResourceInventoryItem resInventoryItem, float rate)
		{
		}
	}

	[SerializeField]
	private GameObject _iconPrefab;

	[SerializeField]
	private RectTransform _iconsRoot;

	private bool _isInitialized;

	public void Show(ResourceGacha resGacha, List<ResourceGacha.Pickup> pickups)
	{
	}

	private void Initialize(int iconCount)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}

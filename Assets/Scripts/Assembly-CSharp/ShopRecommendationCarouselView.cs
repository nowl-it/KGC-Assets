using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FancyCarouselView.Runtime.Scripts;
using UnityEngine;

public class ShopRecommendationCarouselView : CarouselView<ShopRecommendationCarouselCell.Data, ShopRecommendationCarouselCell>
{
	[Serializable]
	private struct ItemPrefabPoolData
	{
		public PackageItem.PackageType _packageType;

		public PackageItem item;
	}

	[SerializeField]
	private Transform _itemPrefabPoolRoot;

	private PackageItem[] _carouselItems;

	private List<ItemPrefabPoolData> _itemPrefabPool;

	private int _lastActiveCellIndex;

	private bool _awaken;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Reload()
	{
	}

	public PackageItem RentPackageItem(PackageItem.PackageType packageType, string holidayType)
	{
		return null;
	}

	public void ReturnPackageItem(PackageItem item)
	{
	}

	public void SwipeToLeft()
	{
	}

	public void SwipeToRight()
	{
	}

	private void InitializeCarousel(string holidayType, int index)
	{
	}

	private GameObject InitializeTreasurePickupCarousel(Match match)
	{
		return null;
	}
}

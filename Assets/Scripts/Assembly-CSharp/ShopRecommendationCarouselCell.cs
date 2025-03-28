using FancyCarouselView.Runtime.Scripts;
using UnityEngine;

public class ShopRecommendationCarouselCell : CarouselCell<ShopRecommendationCarouselCell.Data, ShopRecommendationCarouselCell>
{
	public class Data
	{
		public PackageItem.PackageType packageType;

		public string holidayType;
	}

	[SerializeField]
	private ShopRecommendationCarouselView _view;

	private PackageItem _item;

	protected override void Refresh(Data itemData)
	{
	}
}

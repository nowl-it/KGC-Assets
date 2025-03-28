using FancyCarouselView.Runtime.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class BuySeasonPassCarouselCell : CarouselCell<BuySeasonPassCarouselCell.Data, BuySeasonPassCarouselCell>
{
	public class Data
	{
		public int seasonPassType;
	}

	[SerializeField]
	private BuySeasonPassCarouselView _view;

	[SerializeField]
	private ConditionalGroup _seasonPassTypeCond;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private GameObject _activeBorder;

	protected override void Refresh(Data itemData)
	{
	}

	private void OnEnable()
	{
	}

	private void ReloadActiveBorder(int passType)
	{
	}
}

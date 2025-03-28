using Awesomepiece.Model;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class FirstStepPackageItem : ShopItem
{
	public enum ArrowDirection
	{
		Left = 0,
		Bottom = 1,
		Right = 2,
		Top = 3,
		None = 4
	}

	public static Color OutlineYellowColor;

	public static Color OutlineGrayColor;

	[SerializeField]
	private Image[] _arrows;

	[SerializeField]
	private ConditionalBase _buttonImage;

	[SerializeField]
	private ConditionalBase _lockIcon;

	[SerializeField]
	private AwesomeOutline _lockIconOutline;

	[SerializeField]
	private ConditionalBase _border;

	[SerializeField]
	private ConditionalBase _badge;

	[SerializeField]
	private ConditionalBase _completedImage;

	private ArrowDirection _arrowDirection;

	private Transform _arrowArea;

	private bool _isFirst;

	public void Init(ResourceShopItem resShopItem, ArrowDirection direction, Transform arrowArea, [CanBeNull] ShopItemModel shopItemModel, bool isFirst)
	{
	}

	private void InitPackage()
	{
	}

	public void SetArrow()
	{
	}

	private void ReloadConditional()
	{
	}

	public void Disable()
	{
	}

	public void OnClickBuy()
	{
	}
}

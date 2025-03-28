using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GachaCard : MonoBehaviour, IGachaResult
{
	public RectTransform rectTransform;

	public Text nameText;

	public Text valueText;

	public UnitCard unitCard;

	public Image image;

	public Image frameImage;

	[ComponentConnect]
	public CanvasGroup infoGroup;

	public UnitSoulItem unitSoulItem;

	private Sequence _sequence;

	private Action _cardExpProgress;

	public ShopItemData data;

	public void Set(ShopItemData data)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Skip()
	{
	}

	public bool CanSkip()
	{
		return false;
	}

	public void SetUnit(ResourceUnit resUnit)
	{
	}

	public void SetUnitExp(ResourceUnit resUnit, int exp)
	{
	}

	private void SetArtifactGacha(ShopItemData data)
	{
	}
}

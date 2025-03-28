using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GachaCardOld : MonoBehaviour
{
	public RectTransform rectTransform;

	public Text valueText;

	public UnitCard unitCard;

	public Image white;

	[ComponentConnect]
	public CanvasGroup infoGroup;

	private Sequence _sequence;

	private Action _cardExpProgress;

	public void Set(ShopItemData data)
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
}

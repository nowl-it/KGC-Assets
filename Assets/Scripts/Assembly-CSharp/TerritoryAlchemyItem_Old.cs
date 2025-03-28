using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TerritoryAlchemyItem_Old : MonoBehaviour
{
	[SerializeField]
	private GameObject _selectedBg;

	[SerializeField]
	private Button _releaseButton;

	[FormerlySerializedAs("_alchemyCurrencyItem")]
	[SerializeField]
	private AlchemyCurrencyItem_Old _alchemyCurrencyItemOld;

	public TerritoryAlchemyPanel_Old.AlchemyCurrencyData currencyData;

	private TerritoryAlchemyPanel_Old _parent;

	private bool _isUsing;

	private int _count;

	private IDisposable _bind;

	public void Set(TerritoryAlchemyPanel_Old.AlchemyCurrencyData currencyData, bool isUsing, TerritoryAlchemyPanel_Old parent)
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	public void OnClickRelease()
	{
	}

	public void Release()
	{
	}

	public void OnDisable()
	{
	}

	private void SetCount(int count)
	{
	}
}

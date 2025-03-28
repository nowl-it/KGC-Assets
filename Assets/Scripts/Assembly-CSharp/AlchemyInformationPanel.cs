using System;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyInformationPanel : MonoBehaviour
{
	[SerializeField]
	private Text _alchemyItemPointText;

	[SerializeField]
	private Text _allPointText;

	[SerializeField]
	private UIGridView _currencyItemsView;

	[SerializeField]
	private UIFitter[] _uiFitters;

	[NonSerialized]
	public long alchemyItemPoint;

	[NonSerialized]
	public long allPoint;

	public void Show()
	{
	}

	private void Reload()
	{
	}

	private void ReloadPoints()
	{
	}

	private void UIFit()
	{
	}

	private (long, long) ReloadItems()
	{
		return default((long, long));
	}

	private void SetItem((int ownCount, TerritoryAlchemyCurrencyPanel.AlchemyCurrencyData data) item, GameObject go)
	{
	}

	public void Close()
	{
	}
}

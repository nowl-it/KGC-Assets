using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomPickupSelectTreasurePanel : PopupPanel
{
	[SerializeField]
	private Text _selectCountText;

	[SerializeField]
	private Button _selectButton;

	[SerializeField]
	private UIGridView _gridView;

	private ResourceGacha _resGacha;

	private ResourceGacha.Pickup _resPickup;

	private List<ResourceTreasure> _allTreasures;

	private int[] _selectedTreasures;

	private Action<int[]> _onClose;

	private bool _isTreasureAllSelected => false;

	public override void Show()
	{
	}

	private void SetTreasureUIItem(int idx, GameObject go)
	{
	}

	private void OnClickTreasureUIItem(TreasureUIItem item)
	{
	}

	public void SetOnClose(Action<int[]> callback)
	{
	}

	public void SetResGacha(ResourceGacha resGacha)
	{
	}

	private void Reload()
	{
	}

	public void OnClickSelectButton()
	{
	}

	public override void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}
}

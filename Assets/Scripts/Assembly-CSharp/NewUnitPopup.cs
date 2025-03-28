using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewUnitPopup : Popup
{
	public RectTransform box;

	public Text nameText;

	public Image unitImage;

	private int _unit;

	public GameObject leftArrow;

	public GameObject rightArrow;

	private int currentUnitIndex;

	private List<int> unitIds;

	public List<NewUnitPopupItem> popupItems;

	public void Show(int unit, Action<bool> callback)
	{
	}

	public void Show(List<int> unitIds, Action<bool> callback)
	{
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	private void Reset(int unit)
	{
	}

	public new bool Close()
	{
		return false;
	}
}

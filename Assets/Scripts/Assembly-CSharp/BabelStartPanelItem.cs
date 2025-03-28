using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class BabelStartPanelItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _selectedObject;

	[SerializeField]
	private Image _itemIcon;

	[NonSerialized]
	public GameCompleteRequestModel.EndItemUnit item;

	public bool isSelected => false;

	public void Set(GameCompleteRequestModel.EndItemUnit item)
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool set)
	{
	}
}

using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class AccessorySynergyToolTip : MonoBehaviour
{
	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	[SerializeField]
	public Image _synergyIcon;

	[SerializeField]
	public Text _synergyName;

	[SerializeField]
	private Image[] _accessoryIconImages;

	[SerializeField]
	private FlexibleUIElements _synergyTextItemElements;

	[SerializeField]
	private Border _border;

	public int duration;

	private ulong? _key;

	public void Show(int synergy, CardData cardData, List<AccessoryModel> equippedAccessories, int synergyCount = -1, bool showDisabled = true)
	{
	}

	public void SetOnClose(Action action)
	{
	}

	public Vector2 GetPanelSize()
	{
		return default(Vector2);
	}
}

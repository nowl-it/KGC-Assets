using System;
using UnityEngine;
using UnityEngine.UI;

public class GachaShopIcon : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Text _name;

	[SerializeField]
	private GameObject _freeIcon;

	[SerializeField]
	private GameObject _newIcon;

	[SerializeField]
	private ConditionalGroup _selectedConditionals;

	private ResourceGacha _resGacha;

	private Action _onClick;

	public void Set(ResourceGacha resGacha, Action onClick)
	{
	}

	public void Reload()
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool selected)
	{
	}
}

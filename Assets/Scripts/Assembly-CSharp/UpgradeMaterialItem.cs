using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMaterialItem : MonoBehaviour
{
	[SerializeField]
	private ClickableShopItemIcon _itemIcon;

	[SerializeField]
	private LongPressButton _removeButton;

	[SerializeField]
	private Text _ownCountText;

	[SerializeField]
	private Text _usingCountText;

	[SerializeField]
	private GameObject _highlight;

	[NonSerialized]
	public InventoryItem inventoryItem;

	public ResourceInventoryItem resInventoryItem;

	private int _ownAmount;

	private int _usingCount;

	private Action _onValueChanged;

	private Func<int, bool> _checkFunc;

	private bool _interactable;

	public int usingCount => 0;

	public void Set(InventoryItem inventoryItem, Func<int, bool> checkFunc, Action onValueChanged, bool interactable = true)
	{
	}

	public void AddAmount()
	{
	}

	public void MinusAmount()
	{
	}

	public void SetAmount(int amount)
	{
	}

	private void OnDestroy()
	{
	}
}

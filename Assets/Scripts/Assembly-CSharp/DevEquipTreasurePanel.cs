using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class DevEquipTreasurePanel : MonoBehaviour
{
	[Header("Treasure")]
	public InputField searchInput;

	public RectTransform scrollView;

	public RectTransform elementParent;

	public GameObject elementPrefab;

	public GameObject setLevelObj;

	public GameObject setOvercomeObj;

	[Header("Accessory")]
	public InputField accessoryLevelInputField;

	public Dropdown setSynergyDropdown;

	public Dropdown mainStatDropdown;

	public Dropdown[] subStatDropdowns;

	public InputField[] subStatInputFields;

	public Toggle[] accessoryToggles;

	private int _targetUnitId;

	private Action<ResourceTreasure> _onClose;

	private List<GameObject> _elements;

	private int _poolIdx;

	private TreasureModel _equippedTreasure;

	private List<AccessoryModel> _equippedAccessories;

	private int _accessorySlotIdx;

	public void Show(int index, Action<ResourceTreasure> onClose)
	{
	}

	private void ReloadTreasureElements(string searchStr = null)
	{
	}

	private void OnClickTreasureElement(int id)
	{
	}

	public void SetTreasureLevel()
	{
	}

	public void SetOvercome()
	{
	}

	private void ReloadAllFieldUnit()
	{
	}

	public void OnClickClearSearch()
	{
	}

	public void OnChangeSearch()
	{
	}

	private void ReloadAccessoryPanel()
	{
	}

	private void ReloadAccessorySlot(int idx)
	{
	}

	private void ReloadSubStats(AccessoryModel targetAccessoryModel, string mainStatStr)
	{
	}

	public void ClearAccessory()
	{
	}

	public void OnAccessoryChanged()
	{
	}

	public void OnAccessoryToggle(int idx)
	{
	}

	public void OnClickClose()
	{
	}

	public void OnClickSaveAsEarlyAccessAccessory()
	{
	}
}

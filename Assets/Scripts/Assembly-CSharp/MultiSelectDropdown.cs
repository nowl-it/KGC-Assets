using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiSelectDropdown : MonoBehaviour
{
	public class OptionData
	{
		public string text;

		public OptionData(string value)
		{
		}
	}

	public GameObject dropdownItemTemplate;

	public Transform dropdownItemParent;

	public GameObject dropdownList;

	public Text captionText;

	public ConditionalText arrow;

	public ConditionalGroup selectedCond;

	public int maxSelections;

	private bool _isDropdownOpen;

	public List<OptionData> optionList;

	[NonSerialized]
	public List<int> selectedOptionIdx;

	private List<int> _lastSelectedOptionIdx;

	private Action _onValueChanged;

	private void Awake()
	{
	}

	public void ToggleDropdown()
	{
	}

	public void SetValueChangedCallback(Action onValueChanged)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public bool OnOptionToggleChanged(int idx, bool on)
	{
		return false;
	}

	public void ResetSelectedOptions()
	{
	}

	public void ClearOptions()
	{
	}

	public void AddOptions(List<string> options)
	{
	}

	public void SelectOption(int idx)
	{
	}

	public void RefreshCaptionText()
	{
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoicePackageUnitPanel : PopupPanel
{
	[SerializeField]
	private GridLayoutGroup _unitsRoot;

	[SerializeField]
	private ChoicePackageUnitItem _unitPrefab;

	private List<ChoicePackageUnitItem> _units;

	private Action<int> _choiceCallback;

	private int _lastSelectedIndex;

	private int _selectedIndex;

	public void Show(Action<int> choiceCallback, List<int> exceptUnits)
	{
	}

	public void OnClickClose(bool choice)
	{
	}

	public override void OnClickClose()
	{
	}

	public void OnClickUnit(int index)
	{
	}

	public void ResetLastSelectedIdx()
	{
	}
}

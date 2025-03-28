using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryBonusUnitTooltip : MonoBehaviour
{
	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private TextFitter _titleTextFitter;

	[SerializeField]
	private FlexibleUIElements _unitIconElements;

	[SerializeField]
	private LayoutFitter _layoutFitter;

	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	private List<ResourceUnit> _bonusUnits;

	public void ShowRole(ResourceUnit.Role role, Vector3 worldPos, Func<ResourceUnit, bool> action = null, bool clampPositionNew = false)
	{
	}

	public void ShowRegion(ResourceUnit.Region region, Vector3 worldPos, Func<ResourceUnit, bool> action = null, bool clampPositionNew = false)
	{
	}

	public void SetTitle(string title)
	{
	}

	private void SetPositionFromWorldPosition(Vector3 worldPos, bool clampPositionNew)
	{
	}

	private void ShowImpl(string title)
	{
	}

	private void SetUnitIcon(int index, GameObject go, ImageTextPair image)
	{
	}

	public void Close()
	{
	}
}

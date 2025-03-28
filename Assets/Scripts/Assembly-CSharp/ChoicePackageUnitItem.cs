using System;
using UnityEngine;
using UnityEngine.UI;

public class ChoicePackageUnitItem : MonoBehaviour
{
	[SerializeField]
	private ConditionalGroup _selectedCond;

	[SerializeField]
	private Image _unitIcon;

	[SerializeField]
	private Image _regionIcon;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Text _nameText;

	private int _index;

	[NonSerialized]
	public int unitId;

	private bool _selected;

	public bool selected
	{
		set
		{
		}
	}

	public void Set(int index, int unitId)
	{
	}

	public void OnClick()
	{
	}
}

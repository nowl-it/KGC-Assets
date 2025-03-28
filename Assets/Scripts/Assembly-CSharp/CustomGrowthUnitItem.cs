using UnityEngine;
using UnityEngine.UI;

public class CustomGrowthUnitItem : MonoBehaviour
{
	[SerializeField]
	private Image _unitImage;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Image _regionIcon;

	[SerializeField]
	private Image _highlight;

	[SerializeField]
	private Image _blockImage;

	public ResourceUnit resUnit;

	private bool _selected;

	public void Init(ResourceUnit resUnit, bool block)
	{
	}

	public void SetSelected(bool selected)
	{
	}
}

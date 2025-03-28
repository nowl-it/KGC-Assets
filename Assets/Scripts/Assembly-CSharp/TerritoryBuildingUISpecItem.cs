using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuildingUISpecItem : MonoBehaviour
{
	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Border _border;

	[SerializeField]
	private TextFitter _descTextFitter;

	public void Set(string title, string desc)
	{
	}
}

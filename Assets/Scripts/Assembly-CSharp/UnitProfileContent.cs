using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitProfileContent : MonoBehaviour
{
	[SerializeField]
	private Image _contentTitleBox;

	[SerializeField]
	private Text _contentTitleText;

	[SerializeField]
	private Text _contentText;

	[SerializeField]
	private List<UIFitter> _uiFitters;

	public void Set(ResourceUnit resUnit, string title, string data)
	{
	}
}

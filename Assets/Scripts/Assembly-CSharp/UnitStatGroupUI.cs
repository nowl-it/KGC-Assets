using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitStatGroupUI : MonoBehaviour
{
	[SerializeField]
	private Text _categoryText;

	[SerializeField]
	private RectTransform _statsRoot;

	[SerializeField]
	private UIElements _statObjPrefab;

	[SerializeField]
	private UIFitter[] _uiFitters;

	[SerializeField]
	private Sprite[] _rangeSprites;

	private List<UIElements> _statObjs;

	public void Set(GameUnit unit, Constants.StatCategory category)
	{
	}
}

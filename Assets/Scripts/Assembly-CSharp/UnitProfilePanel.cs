using System.Collections.Generic;
using UnityEngine;

public class UnitProfilePanel : PopupPanel
{
	[SerializeField]
	private UnitIllust _illust;

	[SerializeField]
	private RectTransform _contentPrefabsRoot;

	[SerializeField]
	private UnitProfileContent _contentPrefab;

	[SerializeField]
	private List<UnitProfileContent> _contents;

	public void Show(ResourceUnit resUnit)
	{
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DraggableUnitCardGridPanel : MonoBehaviour
{
	private delegate void OnInitialized(int index, CardData cardData, GameObject go);

	[SerializeField]
	private GridLayoutGroup _rootLayout;

	[SerializeField]
	private GameObject _prefab;

	[SerializeField]
	private Text _unitsPageText;

	private List<CardData> _cards;

	private int _page;

	private int _pageCount;

	private string _categoryKey;

	private Comparison<CardData> _sortFunc;

	private Func<CardData, bool> _filter;

	private OnInitialized _onInitialized;

	public void Set<T>(List<CardData> cards, int page = 0, Action<int, CardData, T> onInitialized = null, Func<CardData, bool> filter = null, Comparison<CardData> sortFunc = null, string categoryKey = "OwnHero") where T : DraggableCardBase<CardData>
	{
	}

	public void Reload()
	{
	}

	private void SetPage(int page)
	{
	}

	public void OnClickPageButton(int dir)
	{
	}

	private void AddUnitItem(Transform root, int index, CardData cardData)
	{
	}
}

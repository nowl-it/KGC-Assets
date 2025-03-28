using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeInventoryPanel : MonoBehaviour
{
	private static RogueLikeInventoryPanel _instance;

	[SerializeField]
	private GameObject _itemPrefab;

	[SerializeField]
	private Transform _itemsRoot;

	[SerializeField]
	private RogueLikeItemUI _itemInfoPanel;

	[SerializeField]
	private Button _leftPageButton;

	[SerializeField]
	private Button _rightPageButton;

	[SerializeField]
	private Transform _pageIndicatorsRoot;

	[SerializeField]
	private GameObject _pageIndicatorPrefab;

	[SerializeField]
	private ConditionalGroup _selectButtonConditionals;

	private readonly List<ConditionalImage> _pageIndicators;

	private const int _itemPerPage = 18;

	private int _curPage;

	private int _maxPage;

	private readonly List<RogueLikeInventoryIcon> _icons;

	private Constants.RogueLikeItemType _typesToShow;

	private Action<RogueLikeInventoryIcon> _onClickIcon;

	private RogueLikeInventoryIcon _clickedIcon;

	private Func<Item, RogueLikeArtifactModel, GameUnit, bool> _except;

	private Action _onReload;

	public static RogueLikeInventoryPanel Instance => null;

	public RogueLikeItemUI itemInfoPanel => null;

	public void Show(Transform parent)
	{
	}

	public void Set(Constants.RogueLikeItemType typesToShow, Func<Item, RogueLikeArtifactModel, GameUnit, bool> except, Action<RogueLikeInventoryIcon> onClickIcon, Action onReload)
	{
	}

	public void Reload()
	{
	}

	public void OnClickPageButton(int dir)
	{
	}

	private void ChangePage()
	{
	}

	public void ShowSelectButton()
	{
	}

	public void SetItemInfoPanelY(float y)
	{
	}

	public void OnClickSelectButton()
	{
	}
}

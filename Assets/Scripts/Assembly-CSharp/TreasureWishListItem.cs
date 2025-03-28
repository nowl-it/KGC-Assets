using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TreasureWishListItem : MonoBehaviour
{
	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Text _roleText;

	[Space(20f)]
	[SerializeField]
	private TreasureUIItem _treasureUIItemPrefab;

	[SerializeField]
	private RectTransform _treasureUIItemRoot;

	private List<TreasureUIItem> _treasureUIItems;

	[Space(20f)]
	[SerializeField]
	private UIFitter[] _uiFitters;

	private ResourceTreasure.Rarity _rarity;

	private ResourceUnit.Role _role;

	private TreasureWishListPanel _parent;

	private List<(TreasureModel treasure, int allCount)> _targetList;

	private int _lastSelectedIdx;

	public void Set(ResourceTreasure.Rarity rarity, ResourceUnit.Role role, List<(TreasureModel treasure, int allCount)> targetList, TreasureWishListPanel parent)
	{
	}

	private void Reload()
	{
	}

	private void ReloadElement()
	{
	}

	public void ReleaseTreasure()
	{
	}

	public void OnClickTreasure(int idx)
	{
	}

	public void ShowTreasureInfo(int idx)
	{
	}
}

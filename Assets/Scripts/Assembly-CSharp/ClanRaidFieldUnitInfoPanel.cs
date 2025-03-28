using Awesomepiece.Model;
using UnityEngine;

public class ClanRaidFieldUnitInfoPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private ClanRaidDeckFieldUnit _fieldUnit;

	[SerializeField]
	private ItemInfoPanel[] _itemInfoPanels;

	[SerializeField]
	private RectTransform _itemInfoPanelRoot;

	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	public void Show(GameCompleteRequestModel.EndFieldUnit fieldUnit, ClanRaidCardInfo cardInfo, Transform transform)
	{
	}

	public bool Close()
	{
		return false;
	}
}

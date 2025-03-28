using System;
using UnityEngine;
using UnityEngine.UI;

public class SelectExpPanel : MonoBehaviour, IClosable
{
	public UIGridView layout;

	public Text expText;

	public Button confirmButton;

	public Button buyButton;

	public Price buyButtonPrice;

	public Button closeButton;

	[ComponentConnect]
	public Text labelText;

	[ComponentConnect]
	public GameObject expTag;

	public Text supprotToolTip;

	[SerializeField]
	private Text _sortButtonText;

	[SerializeField]
	private Text _sortDescButtonIcon;

	private int _exp;

	private SelectExpItem _selected;

	private Action<int> _callback;

	private bool _buyMode;

	private bool _loading;

	private bool _waiting;

	private bool _showMaxLvUnits;

	private bool _showLevelSynced;

	private bool _useSyncedLevel;

	public void ShowClanRequestSupport(Action<int> callback, int clanTier)
	{
	}

	public void ShowClanRaidSupporter(Action<int> callback)
	{
	}

	public void ShowTreasureEquipPanel(Action<int> callback)
	{
	}

	public void Show(int exp, Action<int> callback, bool showMaxLvUnits, bool useSyncedLevel, bool checkMaxLevel = true, bool showLevelSynced = true)
	{
	}

	private void ReloadCardsLayout()
	{
	}

	private void ReloadSortButton()
	{
	}

	public void SetSelect(SelectExpItem item)
	{
	}

	public void OnClickConfirm()
	{
	}

	public void SetLoading(bool set)
	{
	}

	public void SetCallback(Action<int> callback)
	{
	}

	public void SetSortDesc()
	{
	}

	public void OnSortChange()
	{
	}

	public void OnClickClose()
	{
	}

	public void Hide()
	{
	}

	public bool Close()
	{
		return false;
	}
}

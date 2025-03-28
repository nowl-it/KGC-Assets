using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class CustomPickupSelectUnitPanel : PopupPanel, IDraggableDeck
{
	[SerializeField]
	private DraggableUnitCard[] _selectedUnits;

	[SerializeField]
	private Image[] _deckBgObjects;

	[SerializeField]
	private RectTransform _deckLayout;

	[SerializeField]
	private GameObject _pickupUnitPrefab;

	[SerializeField]
	private Text _pageText;

	[SerializeField]
	private Button _pageLeftButton;

	[SerializeField]
	private Button _pageRightButton;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Button _selectButton;

	private ResourceGacha _resGacha;

	private DraggableUnitCard _dragging;

	private int[] _selectUnits;

	private List<DraggableUnitCard> _pickupUnits;

	private Action<int[]> _onClose;

	private int _curPageIdx;

	private int _maxPageIdx;

	private const int MAX_PAGE_ITEM_COUNT = 24;

	public override void Show()
	{
	}

	public void SetOnClose(Action<int[]> callback)
	{
	}

	public void SetResGacha(ResourceGacha resGacha)
	{
	}

	private void Reload()
	{
	}

	private void ReloadSelected()
	{
	}

	private void ReloadCards()
	{
	}

	public void OnClickSelectButton()
	{
	}

	private void ShowCardInfo(UnitCard card)
	{
	}

	public void OnClickPageArrow(int index)
	{
	}

	public override void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}

	public void SetDraggingCard(DraggableUnitCard card)
	{
	}

	public void EquipCard(int idx, UnitCard card)
	{
	}

	public void UnEquipCard(UnitCard card)
	{
	}

	public void SwapDeckCard(UnitCard card1, UnitCard card2)
	{
	}

	public void SaveDeck()
	{
	}

	public RectTransform GetDeckLayout()
	{
		return null;
	}

	public UnitCard FindCardFromCurrentDeck(Func<UnitCard, bool> func)
	{
		return null;
	}

	public int[] GetCurrentDeck()
	{
		return null;
	}

	public int GetIndexFromCurrentDeck(UnitCard card)
	{
		return 0;
	}

	public void EquipArtifact(int idx, ArtifactModel artifact)
	{
	}

	public void SetDraggingArtifact(DraggableArtifactCard card)
	{
	}

	public DraggableArtifactCard[] GetEquippedArtifactCards()
	{
		return null;
	}

	public int GetArtifactOptionSum(int unitPos, string type)
	{
		return 0;
	}

	public bool CanEquipCard(int idx, UnitCard card)
	{
		return false;
	}

	public Image GetDeckBgObject(int index)
	{
		return null;
	}
}

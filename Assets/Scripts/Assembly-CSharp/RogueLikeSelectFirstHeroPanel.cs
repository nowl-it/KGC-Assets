using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectFirstHeroPanel : MonoBehaviour, IClosable, IDraggableDeck
{
	[SerializeField]
	public GameObject _unitCardPrefab;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _subNameText;

	[SerializeField]
	private Image _deckBgObject;

	[SerializeField]
	private RectTransform _deckLayout;

	[SerializeField]
	private RectTransform _cardsLayoutTransform;

	[SerializeField]
	private Text _unitPageText;

	[SerializeField]
	private Text _heroCountText;

	[SerializeField]
	private Button _pageLeftButton;

	[SerializeField]
	private Button _pageRightButton;

	[SerializeField]
	private DraggableUnitCard _selectedUnit;

	[Space(20f)]
	[SerializeField]
	private UnitIllust _unitIllust;

	[SerializeField]
	private UnitStatBox _unitStatBox;

	[SerializeField]
	private ConditionalBase[] _setUnitConditionals;

	[SerializeField]
	private FlexibleUIElements _selectedUnitPotentialElements;

	private DraggableUnitCard _dragging;

	private readonly List<CardData> _unitCards;

	private int _currentPage;

	private int _maxPage;

	private const int _unitPerPage = 18;

	private Action _callBack;

	public void Show(Action callBack)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Reload()
	{
	}

	private void HandleSelectedUnitPotentialChanged()
	{
	}

	private void ReloadStats()
	{
	}

	private void ReloadIllust()
	{
	}

	private void ReloadCards()
	{
	}

	private void AddCard(CardData cardData)
	{
	}

	private void ShowCardInfo(UnitCard card)
	{
	}

	private void ReloadUnitPage()
	{
	}

	private void ReloadDeck()
	{
	}

	public void OnClickUnitPageMove(bool right)
	{
	}

	public void OnClickStartButton()
	{
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

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public Image GetDeckBgObject(int index)
	{
		return null;
	}
}

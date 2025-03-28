using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryDraggableUnitCard : DraggableCardBase<CardData>
{
	[SerializeField]
	private SpriteRenderer _frameSprite;

	[SerializeField]
	private Text _unitNameText;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private ConditionalImage _potentialLevelFrame;

	[SerializeField]
	private SpriteRenderer _backgroundRoleIcon;

	[SerializeField]
	private Image _managerIcon;

	[SerializeField]
	private Text _statusText;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Image _regionIcon;

	[SerializeField]
	private GameObject _lockedObjects;

	[SerializeField]
	private Text _lockedText;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private Text _benefitPerText;

	[SerializeField]
	private GameObject _uis;

	[SerializeField]
	private TerritoryMarker _marker;

	[SerializeField]
	[Header("Setup UI")]
	[Space(20f)]
	private List<SpriteRenderer> _spriteRenderers;

	private UnitController _unitPrefab;

	private Action<CardData, TerritoryDraggableUnitCard> _onClick;

	private bool _showOriginLevel;

	private Transform _uisOriginalParent;

	private bool _isUI;

	public Image roleIcon => null;

	public Image regionIcon => null;

	public void Set(CardData card, bool showOriginLevel = false, ScrollRect parentScrollRect = null, bool bgActive = false)
	{
	}

	public override void Reload()
	{
	}

	private void ReloadPrefab(ResourceUnit resUnit)
	{
	}

	protected override void OnBeginDrag(Vector2 mousePosition)
	{
	}

	protected override void OnDrag(Vector2 mousePosition)
	{
	}

	protected override void OnEndDrag(Vector2 mousePosition)
	{
	}

	protected override void SetDragTargetSortingOrder(int order)
	{
	}

	protected override void OnDragIntoSlot(DraggableCardBase<CardData> toCard, int fromIndex, int toIndex)
	{
	}

	protected override void OnSwapCard(DraggableCardBase<CardData> toCard, int fromIndex, int toIndex)
	{
	}

	public override void Restore()
	{
	}

	protected override void OnUnEquip(int fromIndex)
	{
	}

	public override void SetBaseSortingOrder(int order)
	{
	}

	public void SetBackgroundIcon(Sprite icon)
	{
	}

	public void SetLocked(bool locked, string reason)
	{
	}

	public void HideStatusText()
	{
	}

	public void SetStatusText(string key, Color color)
	{
	}

	public void ShowScoreText(string text, bool useUniqueColor)
	{
	}

	public void ShowManagerIcon(bool show)
	{
	}

	public void SetLevelTextColor(Color color)
	{
	}

	public void ResetLevelTextColor()
	{
	}

	public void SetFrameColor(Color color)
	{
	}

	public void ShowMarker(TerritoryMarker.Type type)
	{
	}

	public void SetCellColor(Color color)
	{
	}

	private void SetupUI(bool bgActive)
	{
	}

	public void SetCanvasSortingOverride(bool set)
	{
	}
}

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableUnitCard : UnitCard, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Serializable]
	public struct StatusBox
	{
		public GameObject gameObject;

		public Text text;
	}

	public bool slot;

	public SpriteRenderer bg;

	public Transform uis;

	public Transform unitObj;

	[CanBeNull]
	public Canvas unitObjCanvas;

	public UnitController unitPrefab;

	public Text statusText;

	public StatusBox statusBox;

	[Space(20f)]
	public Animator setEffect;

	public ArtifactEffectIcon[] artifactEffects;

	public GameObject newObject;

	public Text accountNameText;

	public ConditionalImage potentialLevelBox;

	[SerializeField]
	private TreasureUIItem _treasureItem;

	[SerializeField]
	private RectTransform _unitPrefabDraggingRoot;

	private (RectTransform parent, int siblingIndex) _unitPrefabOriginRoot;

	private IDraggableDeck _deck;

	private DraggableUnitCard _oldSelectedCard;

	private Image _oldSelectedBg;

	private bool _draggable;

	private bool _dragging;

	private int _baseSortingOrder;

	private static Vector3 ORIGIN_POS;

	public Gauge soulGuage;

	public ConditionalImage soulGaugeCond;

	public Image soulGaugeNoob;

	[HideInInspector]
	public int pageId;

	private string _prefabName;

	public GameObject potentialObj;

	public Image potentialIcon;

	[SerializeField]
	[Space(20f)]
	[Header("Setup UI")]
	private List<SpriteRenderer> _spriteRenderers;

	private bool _isUI;

	private float _originUiY;

	private bool _interactableArtifactEffectIcon;

	[Header("ETC Features")]
	[SerializeField]
	[Space(20f)]
	private Button _artifactEffectIconButton;

	public override void Set(CardData cardData, Action<UnitCard> onClickCallback = null, bool own = true, bool usingCard = false, bool showSkin = true, bool canNotUseCard = false, bool showOriginLevel = false, bool showExpGauge = true, bool showPotential = true)
	{
	}

	public void SetUIsActive(bool active, bool exceptNameText = false)
	{
	}

	public void UpdatePotentialIcon()
	{
	}

	public void SetAccountName(string accountName, bool expired = false)
	{
	}

	public void ReloadPrefab(bool showSkin = true)
	{
	}

	public void Idle()
	{
	}

	protected override void Reload()
	{
	}

	public void ReloadGauge()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void SwapCard(DraggableUnitCard selected, int targetIdx)
	{
	}

	public void Restore()
	{
	}

	public void SetEffect()
	{
	}

	public void SetPageId(int pageId)
	{
	}

	public void ReloadArtifactEffects(int idx = -1)
	{
	}

	public void SetBaseSortingOrder(int v)
	{
	}

	public void SetDeck(IDraggableDeck deck)
	{
	}

	public void SetDraggable(bool v)
	{
	}

	public void SetStatusBox(bool v, string text = null)
	{
	}

	public void SetupUI()
	{
	}

	public void ShowStatPopup()
	{
	}
}

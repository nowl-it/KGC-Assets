using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableArtifactCard : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public Image itemImage;

	public Transform dragTarget;

	public Canvas itemCanvas;

	public Image bgBox;

	public Text statusText;

	public Text countText;

	public Image disabledObject;

	public Image selectedObject;

	public Image frameImage;

	public UIEffect[] selectedEffect;

	public PressToScale pressToScale;

	public Gauge polishGauge;

	public GameObject artifactOptionLayout;

	public Image[] artifactOptionImages;

	public Image[] artifactOptionMaxLevelImages;

	public bool slot;

	public ArtifactModel artifact;

	public ConditionalImage favoriteIcon;

	public List<ArtifactModel> artifacts;

	public ScrollRect parentScrollRect;

	private bool _draggable;

	private bool _dragging;

	private Action<DraggableArtifactCard> _onClick;

	private DraggableArtifactCard _oldSelected;

	[HideInInspector]
	public int pageId;

	private Vector3 _originScale;

	private IDraggableDeck _deck;

	public static bool tutorialBlockOnClick;

	public ResourceArtifact resArtifact { get; private set; }

	public bool disabled { get; private set; }

	public bool isSelected { get; private set; }

	public void Init(ArtifactModel initArtifact, Action<DraggableArtifactCard> onClick = null)
	{
	}

	public static void SetArtifactOptionIcon(Image[] artifactOptionImages, Image[] artifactOptionMaxLevelImages, ArtifactModel artifact, bool setOptionColor = true)
	{
	}

	public void InitByList(List<ArtifactModel> initArtifacts, Action<DraggableArtifactCard> onClick = null)
	{
	}

	public void SetEquipped(bool v)
	{
	}

	public void SetDraggable(bool v)
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

	public void Restore()
	{
	}

	public void OnClick()
	{
	}

	public void SetPageId(int newPageId)
	{
	}

	public void SetSelected(bool v)
	{
	}

	public void SetDisabled(bool v)
	{
	}

	private void SetGaugeEnabled(bool v)
	{
	}

	private void SetCustomTypeIcon()
	{
	}

	public void SetDeck(IDraggableDeck deck)
	{
	}
}

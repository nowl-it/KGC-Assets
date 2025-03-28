using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RogueLikeSelectHeroIcon : DraggableUI
{
	[SerializeField]
	private Image _portraitImage;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Gauge _expGauge;

	[SerializeField]
	private ConditionalImageColor _expGaugeColorConditional;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Image _potentialIconImage;

	[SerializeField]
	private ConditionalGroup _selectedConditionals;

	[SerializeField]
	private ConditionalGroup _tierConditionals;

	[SerializeField]
	private ConditionalGroup _potentialTierConditionals;

	protected RogueLikeCardData _cardData;

	protected Action<RogueLikeCardData> _onClick;

	public RogueLikeCardData cardData => null;

	public new void Awake()
	{
	}

	public void Set(RogueLikeCardData cardData, Action<RogueLikeCardData> onClick)
	{
	}

	public virtual void Reload()
	{
	}

	public void SetExpGauge(int exp)
	{
	}

	public virtual void OnClick()
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}
}

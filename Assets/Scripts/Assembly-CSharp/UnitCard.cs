using System;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

public class UnitCard : MonoBehaviour
{
	public Image unitSprite;

	public UIEffect spriteEffect;

	public Text nameText;

	public Text levelText;

	public Gauge expGauge;

	public GameObject emptyObject;

	public ConditionalImage gaugeCond;

	public GameObject levelBox;

	protected bool _usingCard;

	protected bool _ownCard;

	protected bool _canNotUseCard;

	[HideInInspector]
	public CardData cardData;

	protected Action<UnitCard> _onClickCallback;

	private bool _awaked;

	protected bool _showOriginLevel;

	protected bool _showExpGauge;

	protected bool _showPotential;

	public static bool tutorialBlockOnClick;

	public bool usingCard => false;

	public bool ownCard => false;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void Set(CardData cardData, Action<UnitCard> onClickCallback = null, bool own = true, bool usingCard = false, bool showSkin = true, bool canNotUseCard = false, bool showOriginLevel = false, bool showExpGauge = true, bool showPotential = true)
	{
	}

	protected virtual void Reload()
	{
	}

	public void OnClick()
	{
	}
}

using DG.Tweening;
using UnityEngine;

public class RogueLikeDefaultRewardPanelUnitIcon : MonoBehaviour
{
	[SerializeField]
	private RogueLikeHeroIcon _icon;

	[SerializeField]
	private RectTransform _healPreviewGauge;

	[SerializeField]
	private RectTransform _levelUpEffect;

	private float _healPreviewGaugeOriginWidth;

	private RogueLikeCardData _cardData;

	private ulong? _levelUpWorkTimerKey;

	private Tween _levelUpSequence;

	private int _expGain;

	private void Awake()
	{
	}

	public void Set(RogueLikeCardData card, int expGain)
	{
	}

	public void HandlePanelClose()
	{
	}

	public void ShowHealPreview(float healPer)
	{
	}

	public void ShowPotentialUnlockText(int level)
	{
	}
}

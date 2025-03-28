using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactOptionLine_Polish : ArtifactOptionLine
{
	[SerializeField]
	private GameObject _outline;

	[SerializeField]
	private Animator _polishAnimation;

	[SerializeField]
	private Image _lockedOverlay;

	[SerializeField]
	private Image[] _levelEffects;

	private Tween[] _levelEffectTweens;

	public int level;

	private int _currentValue;

	private int _nextValue;

	private const ArtifactOptionUI.Size SIZE = ArtifactOptionUI.Size.Normal;

	private static readonly int _polish;

	public override void Set(ArtifactOptionUI.Size size, ArtifactOptionData option)
	{
	}

	public override void SetEmpty(ArtifactOptionUI.Size size)
	{
	}

	public void AnimatePolish()
	{
	}

	public void SetShine(bool v, bool showNextLevel = true)
	{
	}

	public override void StopShine()
	{
	}
}

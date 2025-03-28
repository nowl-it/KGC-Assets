using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumInvadePoint : MonoBehaviour
{
	[SerializeField]
	private Image _background;

	[SerializeField]
	private Image _activeIcon;

	[SerializeField]
	private Transform _effect1;

	[SerializeField]
	private Image _effect2;

	private Tween _tween;

	private bool _actived;

	private bool _lastHave;

	public void Set(bool active, bool have, bool showEffect, float delay = 0f)
	{
	}

	private void EarnEffect(float delay)
	{
	}

	private void SpendEffect(float delay)
	{
	}
}

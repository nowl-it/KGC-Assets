using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpriteFlash : MonoBehaviour
{
	public Color flashColor;

	[Range(0f, 1f)]
	public float amount;

	public bool pixelSnap;

	private List<SpriteRenderer> _targets;

	public List<SpriteRenderer> spriteRenderers;

	private List<Tweener> _tweeners;

	public void Init(SpriteRenderer target)
	{
	}

	public void Init(SpriteRenderer[] targets)
	{
	}

	private void UpdateSprite()
	{
	}

	public void FlashTween(Color color, float time, float delay = 0f, Action onComplete = null)
	{
	}

	public void FlashTweenReverse(Color color, float time, float delay = 0f, Action onComplete = null)
	{
	}
}

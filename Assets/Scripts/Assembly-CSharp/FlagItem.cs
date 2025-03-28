using System.Collections.Generic;
using UnityEngine;

public class FlagItem : MonoBehaviour
{
	private Animator animator;

	public SpriteRenderer flagImage;

	public List<SpriteRenderer> numberImages;

	public void SetFlag(ResourceFlag resFlag, int season)
	{
	}

	public void SetupUI(bool animatorEnabled = true, bool withFrameAnimation = true, bool maskable = true)
	{
	}

	public void SetNumberImagesInterval(float interval)
	{
	}
}

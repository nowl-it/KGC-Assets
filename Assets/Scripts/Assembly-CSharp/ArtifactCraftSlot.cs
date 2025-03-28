using System;
using Awesomepiece.Model;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactCraftSlot : MonoBehaviour
{
	public Image itemBg;

	public Image itemImage;

	public Text countText;

	public Image frameImage;

	public Image effect;

	public GameObject lockObject;

	[CanBeNull]
	public Tooltip tooltip;

	public GameObject artifactOptionLayout;

	public Image[] artifactOptionImages;

	public Image[] artifactOptionMaxLevelImages;

	[NonSerialized]
	public ArtifactModel artifact;

	public bool showInfoOnClick;

	public bool showInfoAsTooltip;

	public void Set(ArtifactModel model, int count, bool setOptionColor = true)
	{
	}

	public void SetEmpty()
	{
	}

	public void SetArenaEmpty()
	{
	}

	public void SetLock(bool set, int reqLevel = -1)
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public void OnClick()
	{
	}

	public void ShowEffect(Action callback)
	{
	}

	public void HideEffect()
	{
	}
}

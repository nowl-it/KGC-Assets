using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameOverGuideObject : BlurPopupPanel, ISimpleTextResource
{
	[SerializeField]
	private Text _guideText;

	[SerializeField]
	private Toggle _reviewGuideToggle;

	public static List<int> GuideList;

	private int _curGuideIndex;

	public override void Show()
	{
	}

	public void Set()
	{
	}

	private void ReloadGuideText()
	{
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	public void OnClickTutorial(int tutorialSteps)
	{
	}

	public void OnClickIngameTutorial()
	{
	}

	public void OnToggleReviewGuide()
	{
	}

	public override bool Close()
	{
		return false;
	}

	[UsedImplicitly]
	public static void Load()
	{
	}
}

using System.Collections.Generic;
using UnityEngine;

public class IngameTutorialPanel : MonoBehaviour
{
	public enum IngameTutorialType
	{
		Normal = 0,
		AutoMerge = 1
	}

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public InverseBlocker inverseBlocker;

	public TutorialStep[] steps1;

	public TutorialStep[] steps2;

	public TutorialStep[] steps3;

	public TutorialStep[] steps4_1;

	public TutorialStep[] steps4_2;

	public TutorialStep[] steps5;

	public TutorialStep[] steps10;

	public TutorialStep[] steps20;

	public TutorialStep[] steps21;

	public TutorialStep[] steps30;

	private TutorialStep[] _curSteps;

	public int step;

	public IngameTutorialType type;

	private List<int> heroQueue;

	public bool blockRaycast { get; private set; }

	public TutorialStep curStep => null;

	public int GetHero()
	{
		return 0;
	}

	public void Show(int step, float delay = 0.3f)
	{
	}

	public void Hide()
	{
	}

	private void SetTouchCamera(bool set)
	{
	}

	private void SetUnitSell(bool set)
	{
	}

	private void SetFieldTouch(bool set)
	{
	}

	private void SetStartButton(bool set)
	{
	}

	private void SetTutorialUI()
	{
	}

	private void BlockRaycast(bool set)
	{
	}

	public void StartTutorial(IngameTutorialType type)
	{
	}

	private void ShowNormalSteps()
	{
	}

	private void ShowAutoMergeSteps()
	{
	}
}

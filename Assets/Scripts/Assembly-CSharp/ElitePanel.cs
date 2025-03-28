using System;
using UnityEngine;
using UnityEngine.UI;

public class ElitePanel : MonoBehaviour, IClosable, IElitePanel
{
	public EliteItem[] eliteItems;

	[ComponentConnect]
	public ConditionalRoot startButton;

	[ComponentConnect]
	public CanvasGroup pointInfo;

	[ComponentConnect]
	public Text remainCountText;

	[ComponentConnect]
	public Text totalLevelText;

	[ComponentConnect]
	public Text rewardText;

	private int foodCost;

	public int remainPoint { get; private set; }

	private int[] _eliteLevels => null;

	private int _currentTheme => 0;

	public void Show()
	{
	}

	private void Reload()
	{
	}

	public static Func<int, string>[] GetDescFormats()
	{
		return null;
	}

	public static int GetTotalLevel(int[] eliteLevels)
	{
		return 0;
	}

	public static int GetRewardPerSum(int[] eliteLevels)
	{
		return 0;
	}

	public void OnClickAdjust(bool start)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickBack()
	{
	}

	public void OnClickPointInfo()
	{
	}

	public int GetRemainPoint()
	{
		return 0;
	}
}

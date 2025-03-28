using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ArenaWinRewardUI : MonoBehaviour
{
	[SerializeField]
	private Text _winRewardTitleText;

	[SerializeField]
	private Text _winRewardSemiUntilAtText;

	[SerializeField]
	private ArenaWinRewardUIItem _arenaWinRewardUIItem;

	[SerializeField]
	private ArenaWinRewardUIItem _arenaWinRewardUIItemSide;

	[SerializeField]
	private RectTransform _winRewardPageIndicatorRoot;

	[SerializeField]
	private ConditionalSetActive _winRewardPageIndicatorPrefab;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	private List<ConditionalSetActive> _winRewardPageIndicators;

	private int _currentWinRewardStep;

	private Tweener _winRewardTween;

	public void Reload()
	{
	}

	private void ReloadWinRewardUI(ArenaWinRewardUIItem arenaWinRewardUIItem, int step)
	{
	}

	public void OnClickWinRewardArrow(int index)
	{
	}

	public void SetAlpha(float a, float time)
	{
	}
}

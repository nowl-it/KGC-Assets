using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumStagePanel : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Text _stageText;

	[SerializeField]
	private Image _stageTimeGauge;

	[SerializeField]
	private Text _stageTimeText;

	[SerializeField]
	private GameObject _overTimeIcon;

	[SerializeField]
	private FlexibleUIElements _stageBuffElements;

	[SerializeField]
	private CanvasGroup _stageBuffTooltip;

	[SerializeField]
	private Border _stageBuffTooltipBorder;

	[SerializeField]
	private TextFitter _stageBuffTooltipDescTextFitter;

	[SerializeField]
	private Text _stageBuffTooltipNameText;

	[SerializeField]
	private Text _stageBuffTooltipDescText;

	private float _stageTimeGaugeWidth;

	private Scene_Game.ColosseumGamePhase _phase;

	private float _phaseLengthSecond;

	private float _phaseEndAt;

	private Action _onTimeOver;

	private float _lastTimeLeft;

	private int _lastTimeLeftSec;

	private CanvasGroup _mainUICanvasGroup;

	private Tween _tooltipTween;

	public float leftTime => 0f;

	private void Awake()
	{
	}

	public void SetPhase(int stage, Scene_Game.ColosseumGamePhase phase, float phaseLengthSecond, Action onTimeOver)
	{
	}

	public void PauseTimer()
	{
	}

	public void ShowOverTime(bool v, float healPer, int phase)
	{
	}

	public void ReloadStageBuffs(List<int> eventTriggers)
	{
	}

	private void SetBuffIcon(int index, GameObject obj, Button button, int eventTrigger)
	{
	}

	private void Update()
	{
	}
}

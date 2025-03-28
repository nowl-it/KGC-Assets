using System;
using UnityEngine;
using UnityEngine.UI;

public class WaveTimerPanel : MonoBehaviour
{
	public static WaveTimerPanel Instance;

	[GetComponent]
	public RectTransform rectTransform;

	[ComponentConnect]
	public Text waveText;

	[ComponentConnect]
	public Text timerText;

	private bool _isTimer;

	private static ulong _waveWaitingHash;

	public void Awake()
	{
	}

	public void SetTimer(int next, float time, Action callback)
	{
	}

	public void SetWave(int wave)
	{
	}

	public void Update()
	{
	}
}

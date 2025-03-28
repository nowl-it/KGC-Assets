using System;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTimeGauge : MonoBehaviour
{
	[SerializeField]
	private Image _gaugeImage;

	[SerializeField]
	private Text _timeText;

	[SerializeField]
	private Vector2 _sizeDelta;

	public void Set(TimeSpan totalTime, TimeSpan timeLeft)
	{
	}

	public void SetByHorizontal(TimeSpan totalTime, TimeSpan timeLeft)
	{
	}
}

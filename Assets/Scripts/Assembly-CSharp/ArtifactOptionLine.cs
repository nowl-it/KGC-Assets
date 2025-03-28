using System.Collections.Generic;
using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactOptionLine : MonoBehaviour
{
	public Image background;

	public Image[] positionIcons;

	[Header("아래 변수들은 꼭 할당하지 않아도 됨")]
	public Image effect;

	public Text valueText;

	public ConditionalGroup levelGaugeConditional;

	public ConditionalSetActive levelConditional;

	public Image[] levelGauge;

	[HideInInspector]
	public bool isEmpty;

	[Space(20f)]
	private Sequence _shineSequence;

	public virtual void Set(ArtifactOptionUI.Size size, ArtifactOptionData optionData)
	{
	}

	public void Set(ArtifactOptionUI.Size size, string type, int level, int value, List<int> targets)
	{
	}

	public void SetShine(ArtifactOptionUI.Size size, bool hideAll = true, bool showNextLevel = true)
	{
	}

	public virtual void StopShine()
	{
	}

	public virtual void SetEmpty(ArtifactOptionUI.Size size)
	{
	}
}

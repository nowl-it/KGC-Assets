using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SimpleArtifactOptionLine : ArtifactOptionLine
{
	[SerializeField]
	private Image[] _effects;

	private Sequence[] _effectSequences;

	public override void Set(ArtifactOptionUI.Size size, ArtifactOptionData optionData)
	{
	}

	public void ShineSlot(int index)
	{
	}

	public override void StopShine()
	{
	}

	public void StopShine(int index)
	{
	}
}

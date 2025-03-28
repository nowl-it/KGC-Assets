using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LoadingEffect : MonoBehaviour
{
	public RectTransform[] targets;

	private List<Sequence> _sequences;

	public void OnEnable()
	{
	}
}

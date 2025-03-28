using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FancyCarouselView.Runtime.Scripts;
using UnityEngine;

public class DotCarouselProgressViewWithActiveElements : ClickableCarouselProgressView
{
	[SerializeField]
	private DotCarouselProgressElement progressElementPrefab;

	private int _activeIndex;

	private List<DotCarouselProgressElement> _progressElementInstances;

	public override event Action<int> ElementClicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void Setup(int elementCount)
	{
	}

	public override void SetActiveIndex(int elementIndex)
	{
	}

	private void OnElementClicked(int index)
	{
	}
}

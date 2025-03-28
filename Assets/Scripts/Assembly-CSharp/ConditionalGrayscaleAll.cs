using System.Collections.Generic;
using Coffee.UIEffects;
using UnityEngine.UI;

public class ConditionalGrayscaleAll : ConditionalBase
{
	private readonly List<UIEffect> _targetUIEffects;

	private readonly List<Image> _targetImages;

	private readonly List<Text> _targetTexts;

	public ValueGrayscalePair[] pairs;

	private bool _isInitialized;

	private void Awake()
	{
	}

	public override void Reload(int value)
	{
	}

	public void ReloadComponents()
	{
	}
}

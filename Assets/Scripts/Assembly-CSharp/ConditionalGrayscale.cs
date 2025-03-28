using Coffee.UIEffects;
using UnityEngine;

[ExecuteInEditMode]
public class ConditionalGrayscale : ConditionalBase
{
	public UIEffect target;

	public ValueBoolPair[] pairs;

	private void Awake()
	{
	}

	public override void Reload(int value)
	{
	}
}

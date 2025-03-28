using UnityEngine;

[ExecuteInEditMode]
public class ConditionalSizeDelta : ConditionalBase
{
	public RectTransform target;

	public ValueVector2Pair[] pairs;

	public override void Reload(int value)
	{
	}
}

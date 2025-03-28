using UnityEngine;

[ExecuteInEditMode]
public class ConditionalAnchoredPosition : ConditionalBase
{
	public RectTransform target;

	public ValueVector3Pair[] pairs;

	public override void Reload(int value)
	{
	}
}

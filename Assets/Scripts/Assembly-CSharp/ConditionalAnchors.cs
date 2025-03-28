using UnityEngine;

[ExecuteInEditMode]
public class ConditionalAnchors : ConditionalBase
{
	public RectTransform target;

	public ValueAnchorsPair[] pairs;

	public override void Reload(int value)
	{
	}
}

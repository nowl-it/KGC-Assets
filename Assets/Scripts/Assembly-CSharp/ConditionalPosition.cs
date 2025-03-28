using UnityEngine;

[ExecuteInEditMode]
public class ConditionalPosition : ConditionalBase
{
	public Transform target;

	public ValueVector3Pair[] pairs;

	public bool localPosition;

	public bool anchoredPosition;

	public override void Reload(int value)
	{
	}
}

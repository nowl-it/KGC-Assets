using UnityEngine;

[ExecuteInEditMode]
public class ConditionalScale : ConditionalBase
{
	public Transform target;

	public ValueVector3Pair[] pairs;

	public override void Reload(int value)
	{
	}
}

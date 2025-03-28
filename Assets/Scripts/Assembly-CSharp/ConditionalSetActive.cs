using UnityEngine;

[ExecuteInEditMode]
public class ConditionalSetActive : ConditionalBase
{
	public GameObject target;

	public ValueBoolPair[] pairs;

	public override void Reload(int value)
	{
	}
}

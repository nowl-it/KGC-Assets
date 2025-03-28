using UnityEngine;

public class ConditionalMonoBehaviourEnabled : ConditionalBase
{
	public MonoBehaviour target;

	public ValueBoolPair[] pairs;

	public override void Reload(int value)
	{
	}
}

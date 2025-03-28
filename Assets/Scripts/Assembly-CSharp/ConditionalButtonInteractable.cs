using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ConditionalButtonInteractable : ConditionalBase
{
	public Button target;

	public ValueBoolPair[] pairs;

	public override void Reload(int value)
	{
	}
}

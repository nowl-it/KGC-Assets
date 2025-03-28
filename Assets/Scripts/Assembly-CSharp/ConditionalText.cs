using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ConditionalText : ConditionalBase
{
	public Text target;

	public ValueStringPair[] pairs;

	public override void Reload(int value)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ConditionalTextColor : ConditionalBase
{
	public Text target;

	public ValueColorPair[] pairs;

	public override void Reload(int value)
	{
	}
}

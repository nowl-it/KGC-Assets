using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ConditionalImageColor : ConditionalBase
{
	public Image target;

	public ValueColorPair[] pairs;

	public override void Reload(int value)
	{
	}
}

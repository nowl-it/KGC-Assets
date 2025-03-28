using UnityEngine;

[ExecuteInEditMode]
public class ConditionalUIGrayScaler : ConditionalBase
{
	public ValueUIGrayscalePair[] pairs;

	public UIGrayScaler target;

	public override void Reload(int value)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ConditionalImage : ConditionalBase
{
	public Image target;

	public bool setNativeSize;

	public ValueSpritePair[] pairs;

	public override void Reload(int value)
	{
	}
}

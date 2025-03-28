using UnityEngine;

[ExecuteInEditMode]
public class ConditionalSpriteRendererColor : ConditionalBase
{
	public SpriteRenderer target;

	public ValueColorPair[] pairs;

	public override void Reload(int value)
	{
	}
}

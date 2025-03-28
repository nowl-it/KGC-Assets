using UnityEngine;

[ExecuteInEditMode]
public class ConditionalSpriteRenderer : ConditionalBase
{
	public SpriteRenderer target;

	public ValueSpritePair[] pairs;

	public override void Reload(int value)
	{
	}
}

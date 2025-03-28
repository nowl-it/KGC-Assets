using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/ToJ Shadow", 14)]
public class ToJShadow : BaseMeshEffect
{
	[SerializeField]
	private Color m_EffectColor;

	[SerializeField]
	private Vector2 m_EffectDistance;

	[SerializeField]
	private bool m_UseGraphicAlpha;

	private List<UIVertex> m_Verts;

	public Color effectColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public bool useGraphicAlpha
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected ToJShadow()
	{
	}

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
	{
	}

	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Outer Bevel", 4)]
[RequireComponent(typeof(Text))]
public class Bevel : BaseMeshEffect
{
	[SerializeField]
	private Color m_HighlightColor;

	[SerializeField]
	private Color m_ShadowColor;

	[SerializeField]
	private Vector2 m_BevelDirectionAndDepth;

	[SerializeField]
	private bool m_UseGraphicAlpha;

	private List<UIVertex> m_Verts;

	public Color highlightColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color shadowColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Vector2 bevelDirectionAndDepth
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

	protected Bevel()
	{
	}

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

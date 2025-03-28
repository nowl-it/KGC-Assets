using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Depth Effect", 2)]
[RequireComponent(typeof(Text))]
public class DepthEffect : BaseMeshEffect
{
	[SerializeField]
	private Color m_EffectColor;

	[SerializeField]
	private Vector2 m_EffectDirectionAndDepth;

	[SerializeField]
	private Vector2 m_DepthPerspectiveStrength;

	[SerializeField]
	private bool m_OnlyInitialCharactersGenerateDepth;

	[SerializeField]
	private bool m_UseGraphicAlpha;

	private Vector2 m_OverallTextSize;

	private Vector2 m_TopLeftPos;

	private Vector2 m_BottomRightPos;

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

	public Vector2 effectDirectionAndDepth
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 depthPerspectiveStrength
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public bool onlyInitialCharactersGenerateDepth
	{
		get
		{
			return false;
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

	protected DepthEffect()
	{
	}

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y, float factor)
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

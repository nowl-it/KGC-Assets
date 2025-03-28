using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
[AddComponentMenu("UI/ToJ Effects/Skew Effect", 5)]
public class SkewEffect : BaseMeshEffect
{
	public enum SkewMode
	{
		TextArea = 0,
		FullRect = 1
	}

	[SerializeField]
	private SkewMode m_SkewMode;

	[SerializeField]
	private Vector2 m_UpperLeftOffset;

	[SerializeField]
	private Vector2 m_UpperRightOffset;

	[SerializeField]
	private Vector2 m_LowerLeftOffset;

	[SerializeField]
	private Vector2 m_LowerRightOffset;

	private List<UIVertex> m_Verts;

	public Vector2 upperLeftOffset
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 upperRightOffset
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 lowerLeftOffset
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 lowerRightOffset
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	protected SkewEffect()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

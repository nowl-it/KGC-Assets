using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Curve Effect", 6)]
[RequireComponent(typeof(Text))]
public class CurveEffect : BaseMeshEffect
{
	public enum CurveMode
	{
		TextArea = 0,
		FullRect = 1
	}

	[SerializeField]
	private CurveMode m_CurveMode;

	[SerializeField]
	private AnimationCurve m_Curve;

	[SerializeField]
	private float m_Strength;

	private List<UIVertex> m_Verts;

	public AnimationCurve curve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float strength
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected CurveEffect()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

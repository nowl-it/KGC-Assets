using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Soft Shadow", 3)]
[RequireComponent(typeof(Text))]
public class SoftShadow : Shadow
{
	[SerializeField]
	private float m_BlurSpread;

	[SerializeField]
	private bool m_OnlyInitialCharactersDropShadow;

	private List<UIVertex> m_Verts;

	public float blurSpread
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool onlyInitialCharactersDropShadow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected SoftShadow()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

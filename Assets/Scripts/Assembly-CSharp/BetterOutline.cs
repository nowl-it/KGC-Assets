using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Better Outline", 0)]
[RequireComponent(typeof(Text))]
public class BetterOutline : Shadow
{
	private List<UIVertex> m_Verts;

	protected BetterOutline()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

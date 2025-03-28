using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Awesome Outline", 15)]
public class AwesomeOutline : Shadow
{
	private static List<UIVertex> verts;

	protected AwesomeOutline()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Inner Bevel", 19)]
[DisallowMultipleComponent]
[RequireComponent(typeof(Text))]
public class InnerBevel : BaseMeshEffect, IMaterialModifier
{
	public enum ColorMode
	{
		Override = 0,
		Additive = 1,
		Multiply = 2
	}

	[SerializeField]
	private ColorMode m_HighlightColorMode;

	[SerializeField]
	public Color m_HighlightColor;

	[SerializeField]
	private ColorMode m_ShadowColorMode;

	[SerializeField]
	public Color m_ShadowColor;

	[SerializeField]
	private Vector2 m_BevelDirectionAndDepth;

	private bool m_NeedsToSetMaterialDirty;

	private Material m_ModifiedMaterial;

	private List<UIVertex> m_Verts;

	public ColorMode highlightColorMode
	{
		get
		{
			return default(ColorMode);
		}
		set
		{
		}
	}

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

	public ColorMode shadowColorMode
	{
		get
		{
			return default(ColorMode);
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

	protected InnerBevel()
	{
	}

	protected override void Start()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	private void Update()
	{
	}

	public virtual Material GetModifiedMaterial(Material baseMaterial)
	{
		return null;
	}
}

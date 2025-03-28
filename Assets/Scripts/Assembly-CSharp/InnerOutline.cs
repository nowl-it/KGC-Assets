using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
[DisallowMultipleComponent]
[AddComponentMenu("UI/ToJ Effects/Inner Outline", 20)]
public class InnerOutline : BaseMeshEffect, IMaterialModifier
{
	public enum ColorMode
	{
		Override = 0,
		Additive = 1,
		Multiply = 2
	}

	[SerializeField]
	private ColorMode m_ColorMode;

	[SerializeField]
	public Color m_OutlineColor;

	[SerializeField]
	private float m_OutlineThickness;

	private bool m_NeedsToSetMaterialDirty;

	private Material m_ModifiedMaterial;

	private List<UIVertex> m_Verts;

	public ColorMode colorMode
	{
		get
		{
			return default(ColorMode);
		}
		set
		{
		}
	}

	public Color outlineColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float outlineThickness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected InnerOutline()
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

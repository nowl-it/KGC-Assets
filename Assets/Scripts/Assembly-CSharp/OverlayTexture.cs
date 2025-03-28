using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Overlay Texture", 18)]
[RequireComponent(typeof(Text))]
[DisallowMultipleComponent]
public class OverlayTexture : BaseMeshEffect, IMaterialModifier
{
	public enum TextureMode
	{
		Local = 0,
		GlobalTextArea = 1,
		GlobalFullRect = 2
	}

	public enum ColorMode
	{
		Override = 0,
		Additive = 1,
		Multiply = 2
	}

	[SerializeField]
	private TextureMode m_TextureMode;

	[SerializeField]
	private ColorMode m_ColorMode;

	[SerializeField]
	public Texture2D m_OverlayTexture;

	private bool m_NeedsToSetMaterialDirty;

	private Material m_ModifiedMaterial;

	private List<UIVertex> m_Verts;

	public TextureMode textureMode
	{
		get
		{
			return default(TextureMode);
		}
		set
		{
		}
	}

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

	public Texture2D overlayTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected OverlayTexture()
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

using UnityEngine;

public class WorldCamera : MonoBehaviour
{
	[SerializeField]
	private Material _worldTextureMaterial;

	public RenderTexture worldTexture { get; private set; }

	private void Start()
	{
	}

	public void UseWorldTexture()
	{
	}

	private void InitTranslucentImages()
	{
	}

	private void UpdateRenderTexture()
	{
	}

	public void OnResolutionChanged()
	{
	}
}

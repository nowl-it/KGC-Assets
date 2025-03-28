using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class TintTextureGenerator : MonoBehaviour
{
	public int k_TintMapSize;

	private Texture2D m_TintTexture;

	private Texture2D tintTexture => null;

	public void Start()
	{
	}

	public void Refresh(Grid grid)
	{
	}

	public void Refresh(Grid grid, Vector3Int position)
	{
	}

	public Color GetColor(Grid grid, Vector3Int position)
	{
		return default(Color);
	}

	public void SetColor(Grid grid, Vector3Int position, Color color)
	{
	}

	private Vector3Int WorldToTexture(Vector3Int world)
	{
		return default(Vector3Int);
	}

	private Vector3Int TextureToWorld(Vector3Int texpos)
	{
		return default(Vector3Int);
	}

	private GridInformation GetGridInformation(Grid grid)
	{
		return null;
	}

	private void RefreshGlobalShaderValues()
	{
	}
}

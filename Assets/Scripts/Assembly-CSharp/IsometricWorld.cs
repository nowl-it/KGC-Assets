using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class IsometricWorld : MonoBehaviour
{
	private static IsometricWorld _instnace;

	private static readonly Vector3 zOneVector3;

	[SerializeField]
	private float _tileRatio;

	[SerializeField]
	private float _tileAngle;

	[SerializeField]
	private float _tileSize;

	[SerializeField]
	private float _tileHeight;

	[SerializeField]
	private bool _staggered;

	private Matrix4x4 _isoMatrix;

	private Matrix4x4 _isoReverseMatrix;

	private List<IsometricObject> _objects;

	public float height;

	public static IsometricWorld Instance => null;

	public float tileRatio
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tileAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tileSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float _halfTileSize => 0f;

	private float _doubleHalfTileSize => 0f;

	public float tileHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool staggered
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	private void UpdateMatrix()
	{
	}

	public Vector3 GetWorldPosition(Vector2Int tilePosition, float yOffset = 0f, float zOffset = 0f, float zyOffset = 0f)
	{
		return default(Vector3);
	}

	public Vector3 GetWorldPosition(Vector3 tilePosition, float yOffset = 0f, float zOffset = 0f, float zyOffset = 0f)
	{
		return default(Vector3);
	}

	public Vector3 GetTilePosition(Vector2 worldPosition)
	{
		return default(Vector3);
	}

	public Vector2Int GetTileIntPosition(Vector2 worldPosition)
	{
		return default(Vector2Int);
	}

	public void Register(IsometricObject isoObject)
	{
	}

	public void Unregister(IsometricObject isoObject)
	{
	}

	public float GetWorldZPosition(float y, float zOffset = 0f)
	{
		return 0f;
	}
}

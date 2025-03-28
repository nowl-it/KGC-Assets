using UnityEngine;

[ExecuteInEditMode]
public class IsometricObject : MonoBehaviour
{
	private Transform _transform;

	private IsometricWorld _isoCore;

	[SerializeField]
	private Vector3 _tilePosition;

	[SerializeField]
	private float _yOffset;

	[SerializeField]
	private float _zOffset;

	[SerializeField]
	private float _zyOffset;

	public bool update;

	public Vector3 tilePosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float tilePositionX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tilePositionY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tilePositionZ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int intTileX => 0;

	public int intTileY => 0;

	public float yOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float zOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float zyOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	public void UpdatePosition()
	{
	}

	public void SetPosition(int x, int y, int z, bool adjust = true)
	{
	}
}

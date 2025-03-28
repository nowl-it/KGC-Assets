using UnityEngine;

public class Moving : MonoBehaviour
{
	private Vector3 _dir;

	private float _speed;

	private float _lifeTime;

	private bool _live;

	private float _zOffset;

	public bool updateZ;

	private Rect _battleManagerRect;

	public void Run(BattleManager battleManager, Vector2 dir, float speed, float lifeTime, float zOffset = 0f)
	{
	}

	public void Update()
	{
	}
}

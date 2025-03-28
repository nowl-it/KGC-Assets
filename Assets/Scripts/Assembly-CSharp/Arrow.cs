using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public enum Type
	{
		Homing = 0,
		Arc = 1,
		None = 2
	}

	public SpriteRenderer spriteRenderer;

	public Rigidbody2D rigidbody;

	public Sprite halfSprite;

	public GameUnit from;

	public Collider2D collider;

	public ParticleSystem particleSystem;

	public ParticleSystem[] particleSystems;

	public ParticleSystem[] subEmitters;

	public TrailRenderer trailRenderer;

	private Type _type;

	private Vector3 _direction;

	private Vector3 _directionOffset;

	private Vector3 _customOffset;

	private bool _live;

	private float _speed;

	private float _maxSpeed;

	private float _acceleration;

	private float _maxDistance;

	private float _movedDistance;

	private bool _piercing;

	private bool _wallPiercing;

	private Vector3 _startPos;

	private float _destroyTimer;

	private float _ignoreWallTimer;

	private Vector3 _goalPos;

	private Action<GameUnit, Vector3, Arrow> _completeCallback;

	private bool _parabolaRotate;

	private Vector2 _beforePos;

	public bool rotateEnabled;

	private GameUnit _target;

	private float _homingRotateSpeed;

	private bool _showDebug;

	private Vector2 _lastTargetPos;

	private float _arcHeight;

	private Animator _animator;

	public void Start()
	{
	}

	public void Shoot()
	{
	}

	public Arrow SetSpeed(float speed)
	{
		return null;
	}

	public Arrow SetCustomOffset(Vector3 customOffset)
	{
		return null;
	}

	public Arrow DirectionTo(Vector3 target)
	{
		return null;
	}

	public Arrow SetAngleOffset(float angle)
	{
		return null;
	}

	public Arrow From(GameUnit from)
	{
		return null;
	}

	public Arrow To(GameUnit target)
	{
		return null;
	}

	public Arrow SetScale(float x, float y)
	{
		return null;
	}

	public Arrow SetType(Type type)
	{
		return null;
	}

	private void UpdateZ()
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateImpl()
	{
	}

	private void HomingUpdate()
	{
	}

	private void ArcUpdate()
	{
	}

	public Arrow Deflect(GameUnit by, GameUnit target)
	{
		return null;
	}

	public void Die()
	{
	}

	private void DestroySelf()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	public Arrow SetCompleteCallback(Action<GameUnit, Vector3, Arrow> callback)
	{
		return null;
	}

	public Arrow SetHomingRotateSpeed(float speed)
	{
		return null;
	}

	public Arrow SetArcHeight(float height)
	{
		return null;
	}

	public Arrow SetArcHeightRandom(float heightRandom)
	{
		return null;
	}

	public Arrow SetAcceleration(float acceleration, float maxSpeed)
	{
		return null;
	}

	public void SetInt(string key, int value)
	{
	}

	public void SetBool(string key, bool value)
	{
	}

	public void SetFloat(string key, float value)
	{
	}

	public void SetTrigger(string trigger)
	{
	}

	public void SetInt(int key, int value)
	{
	}

	public void SetBool(int key, bool value)
	{
	}

	public void SetFloat(int key, float value)
	{
	}

	public void SetTrigger(int trigger)
	{
	}
}

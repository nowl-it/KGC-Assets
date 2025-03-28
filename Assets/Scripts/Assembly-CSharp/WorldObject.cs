using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour, ColliderCallback.ICollider2D
{
	public ColliderCallback weakCollider;

	public bool destroyOnDie;

	private int _id;

	private int _hp;

	private int _maxHp;

	private bool _live;

	private List<WorldObjectHp> _hpSubscribers;

	public void Awake()
	{
	}

	public void Init(int id)
	{
	}

	public void Die()
	{
	}

	public void OnTriggerEnter2DCallback(ColliderCallback callback, Collider2D c)
	{
	}

	public void OnTriggerStay2DCallback(ColliderCallback callback, Collider2D c)
	{
	}

	public void OnTriggerExit2DCallback(ColliderCallback callback, Collider2D c)
	{
	}
}

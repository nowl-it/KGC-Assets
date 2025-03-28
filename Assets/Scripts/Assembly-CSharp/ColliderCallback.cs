using System.Collections.Generic;
using UnityEngine;

public class ColliderCallback : MonoBehaviour
{
	public interface ICollider2D
	{
		void OnTriggerEnter2DCallback(ColliderCallback callback, Collider2D c);

		void OnTriggerStay2DCallback(ColliderCallback callback, Collider2D c);

		void OnTriggerExit2DCallback(ColliderCallback callback, Collider2D c);
	}

	private ICollider2D _target;

	private float _time;

	private float _remainTime;

	private bool _onlyOneHit;

	private List<Collider2D> _callbacked;

	public void Init(ICollider2D target, float time = -1f)
	{
	}

	public void Show(float time = -1f)
	{
	}

	public void End()
	{
	}

	public void SetOnlyOneHit(bool value)
	{
	}

	public void ClearCallbackedList()
	{
	}

	public void Update()
	{
	}

	public void OnTriggerEnter2D(Collider2D c)
	{
	}

	public void OnTriggerStay2D(Collider2D c)
	{
	}

	private void OnTriggerExit2D(Collider2D c)
	{
	}

	private bool CheckCallbacked(Collider2D c)
	{
		return false;
	}
}

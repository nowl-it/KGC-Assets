using UnityEngine;

public abstract class AudioTriggerBase : MonoBehaviour
{
	public enum EventType
	{
		Start = 0,
		Awake = 1,
		OnDestroy = 2,
		OnCollisionEnter = 3,
		OnCollisionExit = 4,
		OnEnable = 5,
		OnDisable = 6
	}

	public EventType triggerEvent;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnCollisionEnter()
	{
	}

	protected virtual void OnCollisionExit()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected abstract void _OnEventTriggered();

	protected virtual void _CheckEvent(EventType eventType)
	{
	}
}

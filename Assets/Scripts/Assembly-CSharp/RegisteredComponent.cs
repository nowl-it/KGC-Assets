using System;
using UnityEngine;

public abstract class RegisteredComponent : MonoBehaviour, IRegisteredComponent
{
	private bool isRegistered;

	private bool isUnregistered;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public Type GetRegisteredComponentBaseClassType()
	{
		return null;
	}
}

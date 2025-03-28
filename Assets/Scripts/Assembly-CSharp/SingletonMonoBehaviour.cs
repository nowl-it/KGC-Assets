using System;
using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour, ISingletonMonoBehaviour where T : MonoBehaviour
{
	public static T Instance => null;

	public virtual bool isSingletonObject => false;

	public static T DoesInstanceExist()
	{
		return null;
	}

	public static void ActivateSingletonInstance()
	{
	}

	public static void SetSingletonAutoCreate(GameObject autoCreatePrefab)
	{
	}

	public static void SetSingletonType(Type type)
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}
}

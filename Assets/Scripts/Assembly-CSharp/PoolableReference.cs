using UnityEngine;

public class PoolableReference<T> where T : Component
{
	private PoolableObject _pooledObj;

	private int _initialUsageCount;

	private T _objComponent;

	public PoolableReference()
	{
	}

	public PoolableReference(T componentOfPoolableObject)
	{
	}

	public PoolableReference(PoolableReference<T> poolableReference)
	{
	}

	public void Reset()
	{
	}

	public T Get()
	{
		return null;
	}

	public void Set(T componentOfPoolableObject)
	{
	}

	public void Set(T componentOfPoolableObject, bool allowNonePoolable)
	{
	}
}

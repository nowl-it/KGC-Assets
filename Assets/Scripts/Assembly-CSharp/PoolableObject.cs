using UnityEngine;

[AddComponentMenu("ClockStone/PoolableObject")]
public class PoolableObject : MonoBehaviour
{
	public int maxPoolSize;

	public int preloadCount;

	public bool doNotDestroyOnLoad;

	public bool sendAwakeStartOnDestroyMessage;

	public bool sendPoolableActivateDeactivateMessages;

	internal bool _isAvailableForPooling;

	internal bool _createdWithPoolController;

	internal bool _destroyMessageFromPoolController;

	internal bool _wasPreloaded;

	internal bool _wasStartCalledByUnity;

	internal ObjectPoolController.ObjectPool _myPool;

	internal int _serialNumber;

	internal int _usageCount;

	protected void Start()
	{
	}

	private static void _InvokeMethodByName(MonoBehaviour behaviour, string methodName)
	{
	}

	private static void _BroadcastMessageToGameObject(GameObject go, string message)
	{
	}

	private static void _BroadcastMessageToAllChildren(GameObject go, string message)
	{
	}

	protected void OnDestroy()
	{
	}

	public int GetSerialNumber()
	{
		return 0;
	}

	public int GetUsageCount()
	{
		return 0;
	}

	public int DeactivateAllPoolableObjectsOfMyKind()
	{
		return 0;
	}

	public bool IsDeactivated()
	{
		return false;
	}

	public PoolableObject[] GetAllPoolableObjectsOfMyKind(bool includeInactiveObjects)
	{
		return null;
	}
}

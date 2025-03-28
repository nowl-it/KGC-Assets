using System.Collections.Generic;
using UnityEngine;

public static class ObjectPoolController
{
	internal class ObjectPool
	{
		private HashSet_Flash<PoolableObject> _pool;

		private PoolableObject _prefabPoolObj;

		private Transform _poolParentDummy;

		internal Transform poolParentDummy => null;

		private void _ValidatePoolParentDummy()
		{
		}

		public ObjectPool(GameObject prefab)
		{
		}

		private void _ValidatePooledObjectDataContainer()
		{
		}

		internal void Remove(PoolableObject poolObj)
		{
		}

		internal int GetObjectCount()
		{
			return 0;
		}

		internal GameObject GetPooledInstance(Vector3? position, Quaternion? rotation)
		{
			return null;
		}

		internal PoolableObject PreloadInstance()
		{
			return null;
		}

		private PoolableObject _NewPooledInstance(Vector3? position, Quaternion? rotation)
		{
			return null;
		}

		internal int _SetAllAvailable()
		{
			return 0;
		}

		internal PoolableObject[] _GetAllObjects(bool includeInactiveObjects)
		{
			return null;
		}

		internal void _SetAvailable(PoolableObject poolObj, bool b)
		{
		}

		private void _SetActive(GameObject obj, bool active)
		{
		}

		private bool _GetActive(GameObject obj)
		{
			return false;
		}

		private void _SetActiveAndSendMessages(GameObject obj, PoolableObject parentPoolObj)
		{
		}

		private void _RecursivelySetInactiveAndSendMessages(GameObject obj, PoolableObject parentPoolObj, bool recursiveCall)
		{
		}
	}

	internal static int _globalSerialNumber;

	internal static bool _isDuringInstantiate;

	private static Dictionary<GameObject, ObjectPool> _pools;

	public static bool isDuringPreload { get; private set; }

	public static GameObject Instantiate(GameObject prefab)
	{
		return null;
	}

	public static GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion quaternion)
	{
		return null;
	}

	public static GameObject InstantiateWithoutPool(GameObject prefab)
	{
		return null;
	}

	public static GameObject InstantiateWithoutPool(GameObject prefab, Vector3 position, Quaternion quaternion)
	{
		return null;
	}

	public static void Destroy(GameObject obj)
	{
	}

	public static void Preload(GameObject prefab)
	{
	}

	internal static ObjectPool _GetPool(PoolableObject prefabPoolComponent)
	{
		return null;
	}

	private static void _DetachChildrenAndDestroy(Transform transform)
	{
	}
}

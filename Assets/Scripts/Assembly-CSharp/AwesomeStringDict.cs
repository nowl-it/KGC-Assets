using System.Collections.Generic;

public class AwesomeStringDict<T>
{
	private struct KeyValue
	{
		public string key;

		public T value;

		public KeyValue(string key, T value)
		{
			this.key = null;
			this.value = default(T);
		}
	}

	private const int COUNT = 53;

	private List<KeyValue>[] _buckets;

	private int[] _usedBucketIndex;

	private int _usedBucketCount;

	private const int CHAIN_CAPACITY = 5;

	private const int CAPACITY = 1024;

	private static List<List<KeyValue>> _pool;

	private static int _poolCount;

	public T this[string key]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	private static int Hash(string key)
	{
		return 0;
	}

	public bool ContainsKey(string key)
	{
		return false;
	}

	public bool TryGetValue(string key, out T ret)
	{
		ret = default(T);
		return false;
	}

	public List<string> RentKeyList()
	{
		return null;
	}

	public T GetValueOrDefault(string key, T @default)
	{
		return default(T);
	}

	public void Clear()
	{
	}

	private static List<KeyValue> Rent()
	{
		return null;
	}

	private static void Release(List<KeyValue> list)
	{
	}
}

using System.Collections.Generic;
using UnityEngine;

public class SimpleAudioPool : MonoBehaviour
{
	private static SimpleAudioPool _instance;

	public GameObject sourcePrefab;

	private List<SimpleAudioSource> _pool;

	public static SimpleAudioPool Instance => null;

	public void Awake()
	{
	}

	public void Init(int poolCount = 0)
	{
	}

	private SimpleAudioSource Create(bool addToPool = true)
	{
		return null;
	}

	public SimpleAudioSource Rent()
	{
		return null;
	}

	public void Return(SimpleAudioSource source)
	{
	}
}

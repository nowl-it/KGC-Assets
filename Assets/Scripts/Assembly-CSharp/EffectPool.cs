using System.Collections.Generic;
using UnityEngine;

public class EffectPool : MonoBehaviour
{
	private Dictionary<string, List<GameObject>> _poolDict;

	private List<UnitEffect> _loopWorldEffects;

	private List<ulong> _byeTriggerTimers;

	private static List<Component> _staticComponents;

	public static bool activated { get; private set; }

	public void Awake()
	{
	}

	public GameObject Rent(string effectName)
	{
		return null;
	}

	public void Return(GameObject effectObject, ResourceSkill.Effect effect)
	{
	}

	public void AddToLoopWorldEffects(UnitEffect effect)
	{
	}

	public void Clear()
	{
	}

	public void RemoveLoopWorldEffects()
	{
	}

	public void StopByeTriggers()
	{
	}

	public ulong ShootByeTrigger(float delay, GameObject go)
	{
		return 0uL;
	}

	public void ShootTrigger(GameObject go, string type)
	{
	}

	public void DestroyAll()
	{
	}
}

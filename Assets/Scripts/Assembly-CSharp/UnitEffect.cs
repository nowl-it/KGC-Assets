using System;
using UnityEngine;

public struct UnitEffect : IEquatable<UnitEffect>
{
	public GameObject gameObject;

	public string prefab;

	public bool loopEffect;

	public ResourceSkill resSkill;

	public ResourceSkill.Effect resEffect;

	private Animator _animator;

	public void SetAnimatorTrigger(string trigger)
	{
	}

	public void SetAnimatorInt(int param, int value)
	{
	}

	public void SetAnimatorFloat(int param, float value)
	{
	}

	public bool IsState(string name)
	{
		return false;
	}

	public void SetAnimatorCurrentTime(float time)
	{
	}

	public bool Equals(UnitEffect other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

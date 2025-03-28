using System;
using UnityEngine;

internal class WaitWhile : CustomYieldInstruction
{
	private Func<bool> _mPredicate;

	public override bool keepWaiting => false;

	public WaitWhile(Func<bool> predicate)
	{
	}
}

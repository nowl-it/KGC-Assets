using System;
using System.Collections.Generic;
using System.Xml;

public abstract class TriggerBase<TCondition, TConditionParams> where TCondition : struct, Enum where TConditionParams : ConditionParams<TCondition>
{
	protected enum BoolOperator
	{
		And = 0,
		Or = 1
	}

	protected delegate bool ConditionChecker(TConditionParams @params);

	protected List<(TCondition condition, ConditionChecker checker)> conditionChecker;

	private float _probability;

	protected TriggerBase()
	{
	}

	protected TriggerBase(XmlNode n, XmlNode inherit)
	{
	}

	protected TriggerBase(TriggerBase<TCondition, TConditionParams> triggerBase)
	{
	}

	protected abstract bool IsSameCondition(TCondition a, TCondition b);

	protected virtual bool CheckConditionsImpl(TConditionParams @params)
	{
		return false;
	}

	protected virtual bool Parse(ref XmlNode n, XmlNode inherit)
	{
		return false;
	}

	public virtual bool Parse<T>(IRecursiveInheritable<T> n, int index) where T : ResourceBase<T>
	{
		return false;
	}

	protected abstract BoolOperator GetOperator(TCondition condition);

	protected abstract int? GetSeed(TConditionParams @params);
}

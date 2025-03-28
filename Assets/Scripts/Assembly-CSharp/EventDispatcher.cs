using System;
using System.Collections.Generic;

public class EventDispatcher
{
	private Dictionary<string, List<Action>> _eventHandlers;

	public void Add(string name, Action callback)
	{
	}

	public void Remove(string name, Action callback)
	{
	}

	public void Dispatch(string name)
	{
	}
}

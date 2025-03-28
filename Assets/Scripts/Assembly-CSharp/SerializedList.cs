using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializedList<T>
{
	[SerializeField]
	private List<T> list;

	public List<T> ToList()
	{
		return null;
	}

	public SerializedList(List<T> list)
	{
	}
}

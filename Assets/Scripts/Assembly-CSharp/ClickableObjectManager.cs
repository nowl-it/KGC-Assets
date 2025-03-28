using System.Collections.Generic;
using UnityEngine;

public class ClickableObjectManager
{
	private static ClickableObjectManager _instance;

	private readonly List<ClickableObject> _objects;

	private readonly List<ClickableObject> _clickedObjects;

	private ClickableObject _clickedObject;

	private Vector2 _lastClickedScreenPos;

	public static ClickableObjectManager Instance => null;

	public void AddClickableObject(ClickableObject obj)
	{
	}

	public void RemoveClickableObject(ClickableObject obj)
	{
	}

	public void Update()
	{
	}

	private ClickableObject GetClickedObject(Vector3 worldMousePos)
	{
		return null;
	}
}

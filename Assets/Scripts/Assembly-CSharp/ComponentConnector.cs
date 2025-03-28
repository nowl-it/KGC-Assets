using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class ComponentConnector : MonoBehaviour
{
	public bool showNotExistLog;

	private const float _interval = 0.1f;

	private float _counter;
}

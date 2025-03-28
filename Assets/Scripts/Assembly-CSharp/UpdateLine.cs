using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class UpdateLine : MonoBehaviour
{
	[Serializable]
	public struct IndexTransformPair
	{
		public int index;

		public Transform transform;

		public bool rotation;

		public float rotationOffset;
	}

	private List<(Transform transform, Vector3 offset)> _targets;

	private LineRenderer _lineRenderer;

	public IndexTransformPair[] indexTransforms;

	public void AddTarget(Transform transform, Vector3 offset = default(Vector3))
	{
	}

	public void Update()
	{
	}

	public void Bye()
	{
	}
}

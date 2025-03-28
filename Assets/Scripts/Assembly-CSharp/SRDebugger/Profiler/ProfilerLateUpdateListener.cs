using System;
using UnityEngine;

namespace SRDebugger.Profiler
{
	public class ProfilerLateUpdateListener : MonoBehaviour
	{
		public Action OnLateUpdate;

		private void LateUpdate()
		{
		}
	}
}

using System;
using System.Diagnostics;
using UnityEngine;

namespace SRDebugger.Profiler
{
	[RequireComponent(typeof(Camera))]
	public class ProfilerCameraListener : MonoBehaviour
	{
		private Camera _camera;

		private Stopwatch _stopwatch;

		public Action<ProfilerCameraListener, double> RenderDurationCallback;

		protected Stopwatch Stopwatch => null;

		public Camera Camera => null;

		private void OnPreCull()
		{
		}

		private void OnPostRender()
		{
		}
	}
}

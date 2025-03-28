using System.Diagnostics;
using SRDebugger.Services;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Profiler
{
	[Service(typeof(IProfilerService))]
	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService
	{
		private const int FrameBufferSize = 400;

		private readonly SRList<ProfilerCameraListener> _cameraListeners;

		private readonly CircularBuffer<ProfilerFrame> _frameBuffer;

		private Camera[] _cameraCache;

		private ProfilerLateUpdateListener _lateUpdateListener;

		private double _renderDuration;

		private int _reportedCameras;

		private Stopwatch _stopwatch;

		private double _updateDuration;

		private double _updateToRenderDuration;

		public float AverageFrameTime { get; private set; }

		public float LastFrameTime { get; private set; }

		public CircularBuffer<ProfilerFrame> FrameBuffer => null;

		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		private void OnLateUpdate()
		{
		}

		private void EndFrame()
		{
		}

		private void CameraDurationCallback(ProfilerCameraListener listener, double duration)
		{
		}

		private int GetExpectedCameraCount()
		{
			return 0;
		}

		private void CameraCheck()
		{
		}
	}
}

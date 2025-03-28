using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDebugCameraService))]
	public class DebugCameraServiceImpl : IDebugCameraService
	{
		private Camera _debugCamera;

		public Camera Camera => null;
	}
}

using SRDebugger.UI.Other;
using SRF.Service;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDebugTriggerService))]
	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService
	{
		private PinAlignment _position;

		private TriggerRoot _trigger;

		public bool IsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PinAlignment Position
		{
			get
			{
				return default(PinAlignment);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void CreateTrigger()
		{
		}

		protected override void OnDestroy()
		{
		}

		private static void OnActiveSceneChanged(Scene s1, Scene s2)
		{
		}

		private void OnTriggerButtonClick()
		{
		}

		private static void SetTriggerPosition(RectTransform t, PinAlignment position)
		{
		}
	}
}

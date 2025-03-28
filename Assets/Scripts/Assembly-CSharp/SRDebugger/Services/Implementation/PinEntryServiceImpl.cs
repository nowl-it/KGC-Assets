using System;
using System.Collections.Generic;
using SRDebugger.UI.Controls;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IPinEntryService))]
	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService
	{
		private PinEntryCompleteCallback _callback;

		private bool _isVisible;

		private PinEntryControl _pinControl;

		private List<int> _requiredPin;

		public bool IsShowingKeypad => false;

		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true)
		{
		}

		[Obsolete]
		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel)
		{
		}

		protected override void Awake()
		{
		}

		private void Load()
		{
		}

		private void PinControlOnComplete(IList<int> result, bool didCancel)
		{
		}

		private void VerifyPin(IList<int> pin)
		{
		}
	}
}

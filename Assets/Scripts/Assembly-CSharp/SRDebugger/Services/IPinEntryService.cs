using System;
using System.Collections.Generic;

namespace SRDebugger.Services
{
	public interface IPinEntryService
	{
		bool IsShowingKeypad { get; }

		void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true);

		[Obsolete("blockInput param is deprecated (and ignored), please use overload without it.")]
		void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel);
	}
}

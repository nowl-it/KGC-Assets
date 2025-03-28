using System;
using SRDebugger.Internal;

namespace SRDebugger.Services
{
	public interface IPinnedUIService
	{
		bool IsProfilerPinned { get; set; }

		event Action<OptionDefinition, bool> OptionPinStateChanged;

		void Pin(OptionDefinition option, int order = -1);

		void Unpin(OptionDefinition option);

		void UnpinAll();

		bool HasPinned(OptionDefinition option);
	}
}

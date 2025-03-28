using System.Collections.Generic;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;

namespace SRDebugger.Internal
{
	public static class OptionControlFactory
	{
		private static IList<DataBoundControl> _dataControlPrefabs;

		private static ActionControl _actionControlPrefab;

		public static OptionsControlBase CreateControl(OptionDefinition from, string categoryPrefix = null)
		{
			return null;
		}

		private static ActionControl CreateActionControl(OptionDefinition from, string categoryPrefix = null)
		{
			return null;
		}

		private static DataBoundControl CreateDataControl(OptionDefinition from, string categoryPrefix = null)
		{
			return null;
		}
	}
}

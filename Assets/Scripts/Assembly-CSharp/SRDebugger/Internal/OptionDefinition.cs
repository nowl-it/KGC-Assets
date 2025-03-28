using SRF.Helpers;

namespace SRDebugger.Internal
{
	public class OptionDefinition
	{
		public string Name { get; private set; }

		public string Category { get; private set; }

		public int SortPriority { get; private set; }

		public MethodReference Method { get; private set; }

		public PropertyReference Property { get; private set; }

		private OptionDefinition(string name, string category, int sortPriority)
		{
		}

		public OptionDefinition(string name, string category, int sortPriority, MethodReference method)
		{
		}

		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property)
		{
		}
	}
}

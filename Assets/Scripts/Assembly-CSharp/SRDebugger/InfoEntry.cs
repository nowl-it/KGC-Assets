using System;

namespace SRDebugger
{
	public sealed class InfoEntry
	{
		private Func<object> _valueGetter;

		public string Title { get; set; }

		public object Value => null;

		public bool IsPrivate { get; private set; }

		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false)
		{
			return null;
		}

		public static InfoEntry Create(string name, object value, bool isPrivate = false)
		{
			return null;
		}
	}
}

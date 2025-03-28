using System;

namespace Awesomepiece
{
	[AttributeUsage(AttributeTargets.Method)]
	public class FakeWebURLAttribute : Attribute
	{
		public string type;

		public string url;

		public FakeWebURLAttribute(string type, string url)
		{
		}
	}
}

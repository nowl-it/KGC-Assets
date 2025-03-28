using System.Reflection;

namespace SRF.Helpers
{
	public class MethodReference
	{
		private MethodInfo _method;

		private object _target;

		public string MethodName => null;

		public MethodReference(object target, MethodInfo method)
		{
		}

		public object Invoke(object[] parameters)
		{
			return null;
		}
	}
}

using System;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceSelectorAttribute : Attribute
	{
		public Type ServiceType { get; private set; }

		public ServiceSelectorAttribute(Type serviceType)
		{
		}
	}
}

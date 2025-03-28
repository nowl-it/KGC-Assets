using System;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ServiceAttribute : Attribute
	{
		public Type ServiceType { get; private set; }

		public ServiceAttribute(Type serviceType)
		{
		}
	}
}

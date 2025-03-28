using System;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceConstructorAttribute : Attribute
	{
		public Type ServiceType { get; private set; }

		public ServiceConstructorAttribute(Type serviceType)
		{
		}
	}
}

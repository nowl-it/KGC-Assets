using System;

namespace SRF
{
	[AttributeUsage(AttributeTargets.Field)]
	public class ImportAttribute : Attribute
	{
		public readonly Type Service;

		public ImportAttribute()
		{
		}

		public ImportAttribute(Type serviceType)
		{
		}
	}
}

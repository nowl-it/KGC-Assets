using System;
using System.Reflection;

namespace SRF.Helpers
{
	public class PropertyReference
	{
		private readonly PropertyInfo _property;

		private readonly object _target;

		public string PropertyName => null;

		public Type PropertyType => null;

		public bool CanRead => false;

		public bool CanWrite => false;

		public PropertyReference(object target, PropertyInfo property)
		{
		}

		public object GetValue()
		{
			return null;
		}

		public void SetValue(object value)
		{
		}

		public T GetAttribute<T>() where T : Attribute
		{
			return null;
		}
	}
}

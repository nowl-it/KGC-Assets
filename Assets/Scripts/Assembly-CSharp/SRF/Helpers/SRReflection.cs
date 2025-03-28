using System;
using System.Reflection;

namespace SRF.Helpers
{
	public static class SRReflection
	{
		public static void SetPropertyValue(object obj, PropertyInfo p, object value)
		{
		}

		public static object GetPropertyValue(object obj, PropertyInfo p)
		{
			return null;
		}

		public static T GetAttribute<T>(MemberInfo t) where T : Attribute
		{
			return null;
		}
	}
}

using UnityEngine;

namespace UiParticles
{
	internal static class SetPropertyUtility
	{
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return false;
		}

		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return false;
		}

		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return false;
		}
	}
}

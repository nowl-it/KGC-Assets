using System.Collections.Generic;
using UnityEngine;

namespace SRDebugger.Internal
{
	public static class SRDebuggerUtil
	{
		public static bool IsMobilePlatform => false;

		public static bool EnsureEventSystemExists()
		{
			return false;
		}

		public static void CreateDefaultEventSystem()
		{
		}

		public static ICollection<OptionDefinition> ScanForOptions(object obj)
		{
			return null;
		}

		public static string GetNumberString(int value, int max, string exceedsMaxString)
		{
			return null;
		}

		public static void ConfigureCanvas(Canvas canvas)
		{
		}
	}
}

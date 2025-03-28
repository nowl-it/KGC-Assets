using UnityEngine;

namespace SRDebugger
{
	public static class AutoInitialize
	{
		[RuntimeInitializeOnLoadMethod]
		public static void OnLoad()
		{
		}
	}
}

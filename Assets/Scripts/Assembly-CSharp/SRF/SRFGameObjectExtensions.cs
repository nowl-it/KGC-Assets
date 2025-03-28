using UnityEngine;

namespace SRF
{
	public static class SRFGameObjectExtensions
	{
		public static T GetIComponent<T>(this GameObject t) where T : class
		{
			return null;
		}

		public static T GetComponentOrAdd<T>(this GameObject obj) where T : Component
		{
			return null;
		}

		public static void RemoveComponentIfExists<T>(this GameObject obj) where T : Component
		{
		}

		public static void RemoveComponentsIfExists<T>(this GameObject obj) where T : Component
		{
		}

		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true) where T : MonoBehaviour
		{
			return false;
		}

		public static void SetLayerRecursive(this GameObject o, int layer)
		{
		}

		private static void SetLayerInternal(Transform t, int layer)
		{
		}
	}
}

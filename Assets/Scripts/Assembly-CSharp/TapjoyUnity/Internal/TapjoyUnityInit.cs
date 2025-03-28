using TapjoyUnity.Internal.UnityCompat;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TapjoyUnity.Internal
{
	public sealed class TapjoyUnityInit : MonoBehaviour
	{
		private static bool initialized;

		private void Awake()
		{
		}

		private static SceneCompat Wrap(Scene scene)
		{
			return default(SceneCompat);
		}
	}
}

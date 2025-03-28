using System.Diagnostics;

namespace SRF.Components
{
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour where T : SRAutoSingleton<T>
	{
		private static T _instance;

		public static T Instance
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public static bool HasInstance => false;

		protected virtual void Awake()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}

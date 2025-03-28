using System.Diagnostics;

namespace SRF.Components
{
	public abstract class SRSingleton<T> : SRMonoBehaviour where T : SRSingleton<T>
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

		public static bool HasInstance
		{
			[DebuggerStepThrough]
			get
			{
				return false;
			}
		}

		private void Register()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Awesomepiece
{
	public static class ResourceManager
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CStartLoadingThread_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action onCompleted;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static bool _loaded;

		public static bool useMultiThreading;

		private static Task _loadingThread;

		private static ConcurrentQueue<Action> _loadingThreadQueue;

		private static bool _loadingThreadCompletable;

		public static bool isLoaded => false;

		[AsyncStateMachine(typeof(_003CStartLoadingThread_003Ed__7))]
		private static void StartLoadingThread(Action onCompleted)
		{
		}

		private static void SetLoadingThreadCompletable()
		{
		}

		public static void EnqueueToLoadingThread(Action action)
		{
		}

		public static void Load(Action callback)
		{
		}

		public static void ReloadAll()
		{
		}
	}
}

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Logo : Scene_Base
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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

	public Image logoImage;

	private bool _canMoveToLoginScene;

	private bool _loginSceneIllustDataFetched;

	private int _loginSceneIllustDataFetchStartTimer;

	private AsyncOperation _loginSceneLoadHandler;

	protected override void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__6))]
	private void Start()
	{
	}

	private new void Update()
	{
	}
}

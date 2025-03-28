using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactCraftTab : ArtifactCraftTabBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public bool effectFinished;

		public Action _003C_003E9__2;

		internal void _003CCraft_003Eb__2()
		{
		}

		internal bool _003CCraft_003Eb__1()
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCraft_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactCraftTab _003C_003E4__this;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		private int _003Ctarget_003E5__2;

		private bool _003CuseDust_003E5__3;

		private ArtifactResultResponseModel _003Cret_003E5__4;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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

	[SerializeField]
	private ArtifactCraftSlot[] _slots;

	[SerializeField]
	private ImageTextPair _cost;

	[SerializeField]
	private ConditionalGroup _actionButton;

	public Button craftButton;

	public override void Init()
	{
	}

	public override void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public override void OnClickSlot(ArtifactCraftSlot slot)
	{
	}

	public override void Clear()
	{
	}

	public override void ReloadCost()
	{
	}

	public override void ReloadActionButtonInteractable()
	{
	}

	private int GetCraftDustCost()
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003CCraft_003Ed__11))]
	public void Craft()
	{
	}

	private ArtifactModel GetArtifact(int id)
	{
		return null;
	}

	public bool Filter(ArtifactModel artifact)
	{
		return false;
	}
}

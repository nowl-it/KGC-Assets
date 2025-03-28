using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class ArtifactMergeTab : ArtifactCraftTabBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public bool effectFinished;

		public Action _003C_003E9__3;

		internal void _003CMerge_003Eb__3()
		{
		}

		internal bool _003CMerge_003Eb__2()
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CMerge_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactMergeTab _003C_003E4__this;

		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		private ResourceArtifact _003CoriginArtifact_003E5__2;

		private ArtifactResultResponseModel _003Cret_003E5__3;

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
	private ArtifactOptionUI[] _options;

	[SerializeField]
	private ImageTextPair _cost;

	[SerializeField]
	private ConditionalGroup _actionButton;

	public List<(ArtifactModel artifact, int count)> selectedItems => null;

	public override void Init()
	{
	}

	public override void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public override void ReloadCost()
	{
	}

	public override void ReloadActionButtonInteractable()
	{
	}

	public override void OnClickSlot(ArtifactCraftSlot slot)
	{
	}

	public override void Clear()
	{
	}

	private int GetMergeGoldCost()
	{
		return 0;
	}

	public void ReloadSelected()
	{
	}

	private void RemoveSelected(int id)
	{
	}

	[AsyncStateMachine(typeof(_003CMerge_003Ed__15))]
	public void Merge()
	{
	}

	public bool Filter(ArtifactModel artifact)
	{
		return false;
	}

	public void OnClickSwapSlot()
	{
	}
}

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactDismantleTab : ArtifactCraftTabBase
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDismantleImpl_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactDismantleTab _003C_003E4__this;

		public List<ArtifactModel> lst;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _count;

	[SerializeField]
	private ImageTextPair _cost;

	public ConditionalGroup actionButton;

	private ArtifactSelectAmountPanel _artifactSelectAmountPanel;

	private bool _processing;

	public ArtifactSelectAmountPanel artifactSelectAmountPanel => null;

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

	private void RemoveFromSelectedItems(DraggableArtifactCard card)
	{
	}

	private void RemoveFromSelectedItemsByItemID(DraggableArtifactCard card)
	{
	}

	private void ReloadDismantleResult()
	{
	}

	private int GetDismantleTargetCounts()
	{
		return 0;
	}

	public void Dismantle()
	{
	}

	[AsyncStateMachine(typeof(_003CDismantleImpl_003Ed__20))]
	private void DismantleImpl(List<ArtifactModel> lst)
	{
	}

	public bool Filter(ArtifactModel artifact)
	{
		return false;
	}
}

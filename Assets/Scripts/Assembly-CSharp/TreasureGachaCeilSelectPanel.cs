using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class TreasureGachaCeilSelectPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickSelect_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureGachaCeilSelectPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

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
	private TreasureCardGachaItem[] _treasureCards;

	[SerializeField]
	private ConditionalGroup[] _selectConditional;

	private ResourceGacha _resGacha;

	private int _selected;

	private Action _onClose;

	public void Show(ResourceGacha resGacha, Action onClose = null)
	{
	}

	public void OnClickCard(int index)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickSelect_003Ed__7))]
	public void OnClickSelect()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}

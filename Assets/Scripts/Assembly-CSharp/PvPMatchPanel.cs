using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PvPMatchPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CMatch_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PvPMatchPanel _003C_003E4__this;

		private bool[] _003Cblinds_003E5__2;

		private UniTask<PvPMatchResponseModel>.Awaiter _003C_003Eu__1;

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

	[ComponentConnect]
	public ConditionalGroup battleButton;

	[SerializeField]
	private Text _battleButtonText;

	[ComponentConnect]
	public CanvasGroup loadingPopup;

	public PvPMatchItem[] items;

	private int _selectedIdx;

	private bool _matchProcessing;

	public List<PvPDeckInfo> matchResults;

	public List<PvPDeckInfo> trainingMatchResults;

	public ConditionalGroup stateCond;

	private bool _isTraining;

	private bool _canTraining;

	public void Show(bool training)
	{
	}

	[AsyncStateMachine(typeof(_003CMatch_003Ed__12))]
	public void Match()
	{
	}

	public void OnClickTarget(int idx)
	{
	}

	public void OnClickBattle()
	{
	}

	public void OnClickTrainingInfo()
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

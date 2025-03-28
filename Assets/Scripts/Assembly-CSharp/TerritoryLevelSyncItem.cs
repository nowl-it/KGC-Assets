using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryLevelSyncItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickButton_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryLevelSyncItem _003C_003E4__this;

		private int _003Cprice_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickResetSync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int price;

		public TerritoryLevelSyncItem _003C_003E4__this;

		private UniTask<Awesomepiece.Model.TerritoryAssignUnitsResponseModel>.Awaiter _003C_003Eu__1;

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
	private TerritoryDraggableUnitCard _unitCard;

	[SerializeField]
	private Button _releaseButton;

	[SerializeField]
	private Text _mainButtonText;

	[SerializeField]
	private ImageTextPair _resetTimer;

	[SerializeField]
	private TerritoryMarker _levelSyncMarker;

	private TerritoryLevelSyncPanel _parent;

	private int _syncedUnit;

	private Action _onClickSelect;

	private Action _onClickRelease;

	private void Update()
	{
	}

	public void CheckSyncTimer()
	{
	}

	public void Set(int unitId, TerritoryLevelSyncPanel parent, Action onClickSelect, Action onClickRelease)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickButton_003Ed__12))]
	public void OnClickButton()
	{
	}

	public void OnClickRelease()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickResetSync_003Ed__14))]
	public void OnClickResetSync(int price)
	{
	}

	public void CheckMarker()
	{
	}

	private void OnDestroy()
	{
	}

	public void TestTerritorySetLevelSyncUntilAt()
	{
	}
}

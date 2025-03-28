using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryHuntingItem _003C_003E4__this;

		private UniTask<TerritoryEndHuntingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CTestSetHuntingId_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryHuntingItem _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

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
	private TerritoryHuntingInfoUI _infoUI;

	[SerializeField]
	private Text _timeLeftText;

	[SerializeField]
	private RectTransform _timeLeftGaugeRectTransform;

	[SerializeField]
	private FlexibleUIElements _assignedUnitElements;

	[SerializeField]
	private Border _assignedUnitsBorder;

	[SerializeField]
	private LayoutFitter _assignedUnitsLayoutFitter;

	[SerializeField]
	private ClickableShopItemIcon _rewardThumbIcon;

	[SerializeField]
	private ConditionalGroup _stateConditionals;

	private TerritoryHuntingData _huntingData;

	private TimeSpan _requiredTime;

	private float _timeLeftGaugeMaxWidth;

	private float _heroAssignmentBenefitPer;

	private ResourceTerritoryBuilding _resBuilding;

	[SerializeField]
	private InputField _huntingIdInputField;

	[SerializeField]
	private InputField _huntingIdFoodBoosterLevel;

	private void Awake()
	{
	}

	public void Set(TerritoryHuntingData huntingData, float heroAssignmentBenefitPer, ResourceTerritoryBuilding resBuilding)
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeLeftGauge()
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__17))]
	public void OnClick()
	{
	}

	public void TestSetRemainTime()
	{
	}

	[AsyncStateMachine(typeof(_003CTestSetHuntingId_003Ed__21))]
	public void TestSetHuntingId()
	{
	}
}

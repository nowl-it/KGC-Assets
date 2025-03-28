using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryPassPanel : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandleBuyComplete_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryPassPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.PlayerTerritoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickBuyPass_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryPassPanel _003C_003E4__this;

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
	private Text _remainTimeText;

	[SerializeField]
	private Text _efficiencyText;

	[SerializeField]
	private List<Text> _benefitTexts;

	[SerializeField]
	private Text _priceText;

	[SerializeField]
	private Text _passDuringTimeText;

	private bool _isInitialized;

	private readonly List<ResourceEventTrigger> _seasonResEventTriggers;

	private ResourceShopItem _resShopItem;

	private int _earnedGold;

	private int _earnedExpItem;

	private void Awake()
	{
	}

	public override void Show()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleBuyComplete_003Ed__12))]
	public void HandleBuyComplete()
	{
	}

	private void Reload()
	{
	}

	private void Update()
	{
	}

	private void UpdateRemainTimeText()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuyPass_003Ed__16))]
	public void OnClickBuyPass()
	{
	}

	public override bool Close()
	{
		return false;
	}
}

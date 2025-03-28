using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

public class ClanRaidDeckSettingPanel : DeckSettingPanel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public BarrackInfo.DeckSettingCardInfo supportCard;

		internal bool _003COnClickStartClanRaidDeckRecord_003Eb__2(ClanRaidSupportModel supporter)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickGuide_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidDeckSettingPanel _003C_003E4__this;

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
	private struct _003COnClickStartClanRaidDeckRecord_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidDeckSettingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		private BarrackInfo _003Cbarrack_003E5__2;

		private int _003CsupportCardIndex_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private int _003Ci_003E5__4;

		private UniTask<ClanRaidSupportResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__3;

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

	public Button startButton;

	public Text startButtonText;

	[NonSerialized]
	public bool blockClose;

	public override void Show()
	{
	}

	protected override void Reload()
	{
	}

	protected override BarrackInfo GetBarrack()
	{
		return null;
	}

	protected override void SetBarrack(BarrackInfo barrackInfo)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStartClanRaidDeckRecord_003Ed__6))]
	public void OnClickStartClanRaidDeckRecord()
	{
	}

	public override bool CanEquipCard(int idx, UnitCard card)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003COnClickGuide_003Ed__8))]
	public void OnClickGuide()
	{
	}

	public override bool Close()
	{
		return false;
	}

	protected override int SortCard(CardData a, CardData b)
	{
		return 0;
	}

	protected override (bool, string) GetStatusBoxInfo(CardData card)
	{
		return default((bool, string));
	}
}

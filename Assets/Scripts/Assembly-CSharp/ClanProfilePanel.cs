using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ClanProfilePanel : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickAttendance_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanProfilePanel _003C_003E4__this;

		private UniTask<ClanAttendanceResponseModel>.Awaiter _003C_003Eu__1;

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
	[SerializeField]
	private ClanInfo _clanInfo;

	[ComponentConnect]
	[SerializeField]
	private ClanSkillList _clanSkillList;

	[ComponentConnect]
	[SerializeField]
	private ClanSkillInfo _clanSkillInfo;

	[SerializeField]
	[ComponentConnect]
	private SimplifiedClanMemberList _clanMemberList;

	[ComponentConnect]
	[SerializeField]
	private SimplifiedClanMemberItem _clanLeader;

	[ComponentConnect]
	[SerializeField]
	private Text _clanNotice;

	[SerializeField]
	private Text _clanTags;

	[SerializeField]
	private TextFitter _tagTextFitter;

	[SerializeField]
	private MovingText _tagTextMovingComponent;

	[SerializeField]
	private ConditionalGroup _attendance;

	[SerializeField]
	private ConditionalGroup _joined;

	[SerializeField]
	private ConditionalSetActive _newRequest;

	[SerializeField]
	private CanvasGroup _clanExpInfo;

	private ClanModel _clanModel;

	private DateTime _lastClanFetchDate;

	private bool _attendanceRequest;

	private Tween _expInfoTween;

	public void Show()
	{
	}

	public void Set(ClanModel clan, bool joined = true)
	{
	}

	public void OnClickMenu()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickAttendance_003Ed__19))]
	public void OnClickAttendance()
	{
	}

	public void OnClickSeeMoreMemberInfos()
	{
	}

	public void ShowExpToolTip()
	{
	}

	public void ShowSkillToolTip(string title, int tier, string desc, int nextTier, string nextTierDesc, int nextTierReqLevel)
	{
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FourthYearEventPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandleBuyComplete_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FourthYearEventPanel _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickBuyPass_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FourthYearEventPanel _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickDevFourthYearEventReset_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<FourthYearEventResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickDevResetPass_003Ed__71 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<FourthYearEventResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickDevSetDay_003Ed__72 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public bool isPassDay;

		public FourthYearEventPanel _003C_003E4__this;

		private UniTask<FourthYearEventResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReceiveDailyAttendanceReward_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FourthYearEventPanel _003C_003E4__this;

		public int day;

		private UniTask<FourthYearEventReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReceiveDailyPassReward_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FourthYearEventPanel _003C_003E4__this;

		private UniTask<FourthYearEventReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReceivePrevPassReward_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FourthYearEventPanel _003C_003E4__this;

		private UniTask<FourthYearEventReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReloadHeartCount_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FourthYearEventPanel _003C_003E4__this;

		private UniTask<PlayerCurrenciesResponseModel>.Awaiter _003C_003Eu__1;

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

	public static FourthYearEventPanel Instance;

	[SerializeField]
	private ConditionalGroup _buyPassCond;

	[SerializeField]
	private TabManager _tabManager;

	private const int ATTENDANCE_TAB = 0;

	private const int PASS_TAB = 1;

	[SerializeField]
	private RectTransform _dailyPassRewardContent;

	private List<FourthYearDailyPassRewardItem> _dailyPassRewardItems;

	public GameObject dailyPassRewardItemPrefab;

	[SerializeField]
	private ConditionalGroup _passRewardReceivedCond;

	private const int CANNOT_RECEIVE = 0;

	private const int RECEIVE_PREV_REWARD = 1;

	private const int RECEIVE_CURRENT_REWARD = 2;

	private const int RECEIVE_ADDITIONAL_REWARD = 3;

	private const int RECEIVE_COMPLETE = 4;

	private const int RECEIVE_ALL_COMPLETE = 5;

	[SerializeField]
	private Text _heartCountText;

	[SerializeField]
	private Gauge _heartGauge;

	[SerializeField]
	private Text _eventRemainTimeText;

	[SerializeField]
	private ScrollRect _attendanceGroupScrollRect;

	[SerializeField]
	private RectTransform _attendanceGroupScrollContent;

	[SerializeField]
	private Image _scrollGradation;

	[SerializeField]
	private List<ClickableShopItemIcon> _attendanceRewardItemIcons;

	[SerializeField]
	private ConditionalGroup _currentAttendanceDayCond;

	[SerializeField]
	private ConditionalGroup _lastAttendanceRewardDayCond;

	[SerializeField]
	private ConditionalGroup _canAttendanceDayCond;

	[SerializeField]
	private PopupPanel _buyPassPopup;

	private bool _buyPassPopupInited;

	private ResourceShopItem _eventPassShopItem;

	[SerializeField]
	private RectTransform buyPassPopupRewardContent;

	private List<FourthYearDailyPassRewardItem> _buyPassPopupRewardItems;

	public GameObject buyPassPopupRewardItemPrefab;

	[SerializeField]
	private Text _passPriceText;

	[SerializeField]
	private Animator _effectAnimator;

	private static readonly int _animOpenTrigger;

	[Header("Test")]
	[SerializeField]
	private InputField _devPassDayInputField;

	[SerializeField]
	private InputField _devAttendanceDayInputField;

	[SerializeField]
	private float _gradationFadeStartY;

	[SerializeField]
	private float _gradationFadeEndY;

	private bool _inited;

	private ResourceFourthYearEventReward _resEventReward;

	private FourthYearEventResponseModel _eventModel;

	private DateTime _eventUntilAt;

	private bool _getRewardProcessing;

	private bool _buyProcessing;

	private const int PASS_REWARD_FINAL_DAY = 11;

	private const int ATTENDANCE_REWARD_FINAL_DAY = 12;

	public void Awake()
	{
	}

	public static void ReloadFourthYearEventButton()
	{
	}

	private void Update()
	{
	}

	private void UpdateRemainTimeText()
	{
	}

	public void Show()
	{
	}

	private void Init()
	{
	}

	public void Reload()
	{
	}

	private void ReloadPassArea()
	{
	}

	private void ReloadAttendanceArea()
	{
	}

	public void OnClickAttendanceRewardItemIcon(int idx)
	{
	}

	[AsyncStateMachine(typeof(_003CReloadHeartCount_003Ed__56))]
	private void ReloadHeartCount()
	{
	}

	public void OnClickReceiveDailyPassRewardButton()
	{
	}

	public void OnClickReceiveDailyAttendanceRewardButton(int day)
	{
	}

	private void HandleRewardResult(FourthYearEventReceiveRewardResponseModel ret)
	{
	}

	[AsyncStateMachine(typeof(_003CReceivePrevPassReward_003Ed__60))]
	private void ReceivePrevPassReward()
	{
	}

	[AsyncStateMachine(typeof(_003CReceiveDailyPassReward_003Ed__61))]
	private void ReceiveDailyPassReward()
	{
	}

	[AsyncStateMachine(typeof(_003CReceiveDailyAttendanceReward_003Ed__62))]
	private void ReceiveDailyAttendanceReward(int day)
	{
	}

	private void InitBuyPassPopup()
	{
	}

	public void OnClickShowPassPopup()
	{
	}

	public void OnClickClosePassPopup()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuyPass_003Ed__66))]
	public void OnClickBuyPass()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleBuyComplete_003Ed__67))]
	public void HandleBuyComplete()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003COnClickDevFourthYearEventReset_003Ed__70))]
	public void OnClickDevFourthYearEventReset()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDevResetPass_003Ed__71))]
	public void OnClickDevResetPass()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDevSetDay_003Ed__72))]
	public void OnClickDevSetDay(bool isPassDay)
	{
	}

	private void OnScrolled(Vector2 _)
	{
	}
}

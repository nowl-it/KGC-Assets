using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TopPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickItemDev_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int idx;

		private int _003Cv_003E5__2;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRecoverHeart_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TopPanel _003C_003E4__this;

		private int _003Cbefore_003E5__2;

		private UniTask<Awesomepiece.Model.PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

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

	public static TopPanel Instance;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Gauge expGauge;

	[ComponentConnect]
	public GetMoneyEffect expGetEffect;

	[ComponentConnect]
	public Gauge heartGauge;

	[ComponentConnect]
	public Text heartTimerText;

	[ComponentConnect]
	public GetMoneyEffect heartGetEffect;

	[ComponentConnect]
	public GetMoneyEffect heartVoucherGetEffect;

	[ComponentConnect]
	public LerpText goldText;

	[ComponentConnect]
	public GetMoneyEffect goldGetEffect;

	[ComponentConnect]
	public LerpText cashText;

	[ComponentConnect]
	public GetMoneyEffect cashGetEffect;

	[ComponentConnect]
	public GameObject inMatchmakingObject;

	[ComponentConnect]
	public GameObject inCustomMatchObject;

	[ComponentConnect]
	public Text matchmakingElapsedTimeText;

	[ComponentConnect]
	public Text serverName;

	private BuyHeartPanel _buyHeartPanel;

	private int _lastLevel;

	private int _lastExp;

	private int _lastHeart;

	private int _lastGold;

	private int _lastGem;

	private DateTime _recoverHeartCoolTime;

	public BuyHeartPanel buyHeartPanel => null;

	public virtual void Awake()
	{
	}

	public virtual void Init()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnApplicationPause(bool pauseStatus)
	{
	}

	private void Update()
	{
	}

	public virtual void ReloadAll(bool force = false)
	{
	}

	public void OnClickItem(int idx)
	{
	}

	public void OnClickCancelMatchmakingButton()
	{
	}

	public void OnClickGoBackToCustomMatchPanel(bool doShortCut = true)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickItemDev_003Ed__34))]
	public virtual void OnClickItemDev(int idx)
	{
	}

	public void ReloadLevelExp()
	{
	}

	public void ReloadLevelExp(bool force)
	{
	}

	public void ReloadHeart()
	{
	}

	public void ReloadGold()
	{
	}

	public void ReloadGold(bool force = false)
	{
	}

	public void ReloadCash()
	{
	}

	public void ReloadCash(bool force = false)
	{
	}

	public void InvasionTutorialForceShowGetCashEffect()
	{
	}

	public void ReloadHeartTimer()
	{
	}

	[AsyncStateMachine(typeof(_003CRecoverHeart_003Ed__45))]
	public void RecoverHeart()
	{
	}

	public void ResetMoneyEffect()
	{
	}
}

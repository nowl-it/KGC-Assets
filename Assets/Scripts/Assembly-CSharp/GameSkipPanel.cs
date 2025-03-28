using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameSkipPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDevSetInvasionSkipCount_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameSkipPanel _003C_003E4__this;

		private UniTask<GameSkipInfoResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickStart_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameSkipPanel _003C_003E4__this;

		private int _003Ctheme_003E5__2;

		private AwesomeInt _003ClastPlayerLevel_003E5__3;

		private RewardListResponseData _003CrewardResponse_003E5__4;

		private UniTask<GameResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

		private UniTask<PlayerDataResponseModel>.Awaiter _003C_003Eu__3;

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
	private Text[] _benefitTexts;

	[SerializeField]
	private ConditionalGroup _inactivePassButton;

	[SerializeField]
	private GameObject _activePassButton;

	[SerializeField]
	[Space(20f)]
	private Button[] _arrowButtons;

	[SerializeField]
	private Slider _skipCountSlider;

	[SerializeField]
	private Button[] _skipCountSliderButtons;

	[SerializeField]
	private Text _skipCountText;

	[SerializeField]
	[Space(20f)]
	private Text _rewardAmountText;

	private Action _onValueChanged;

	private const int SkipMinCount = 1;

	private bool _requestProcess;

	[SerializeField]
	private GameObject _testUI;

	[SerializeField]
	private InputField _invasionSkipCountTextField;

	[SerializeField]
	private InputField _invasionSkipHeartFreeCountTextField;

	private int _ownInvasionSkipCount => 0;

	public int baseFoodCount => 0;

	public int freeHeartCount => 0;

	public int useCount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int maxCount => 0;

	public int foodCount => 0;

	private void Awake()
	{
	}

	public void Set(Action onValueChanged, bool keepValue = false)
	{
	}

	private void Reload()
	{
	}

	private void ReloadKeepValue()
	{
	}

	public void ReloadRewardAmountUI()
	{
	}

	private void ReloadPassBenefitObj()
	{
	}

	public void OnClickSliderButton(int index)
	{
	}

	public void OnClickMax()
	{
	}

	public void OnSliderValueChanged()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStart_003Ed__33))]
	public void OnClickStart()
	{
	}

	public void OnclickPassButton()
	{
	}

	public void ToggleTestUI()
	{
	}

	[AsyncStateMachine(typeof(_003CDevSetInvasionSkipCount_003Ed__39))]
	public void DevSetInvasionSkipCount()
	{
	}
}

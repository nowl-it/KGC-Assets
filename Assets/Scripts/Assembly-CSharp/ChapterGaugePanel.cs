using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChapterGaugePanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReawrd_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ChapterGaugePanel _003C_003E4__this;

		public GameObject rewardButton;

		private TaskAwaiter<MissionRewardResponseModel> _003C_003Eu__1;

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
	public Text maxEliteText;

	[ComponentConnect]
	public Image clearGauge;

	[ComponentConnect]
	public Image clearGaugeEnd;

	[ComponentConnect]
	public Image canGetRewardEffect;

	private Sequence _canGetRewardTween;

	[ComponentConnect]
	public Image rewardGauge;

	[ComponentConnect]
	public Image rewardGaugeEnd;

	[ComponentConnect]
	public ConditionalRoot reward;

	[ComponentConnect]
	public Text noChapterGaugeText;

	[ComponentConnect]
	public GameObject gauge;

	public Animator rewardEffect;

	public Image rewardIcon;

	public Text rewardCount;

	public Button currentRewardButton;

	public ClickableShopItemIcon[] shopItemIcons;

	public ConditionalImage[] keyIcons;

	public ConditionalImageColor[] keyIconColors;

	public ConditionalButtonInteractable[] keyIconButtons;

	public Animator[] keyIconEffects;

	private int[] keyLevels;

	private float[] GuagePos;

	private float[] RewardPos;

	private ResourceMission _rewardMission;

	private bool _processing;

	public void Reload(bool tween = false)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReawrd_003Ed__25))]
	public void OnClickReawrd(GameObject rewardButton)
	{
	}
}

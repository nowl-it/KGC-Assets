using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class MissionItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public bool processed;

		internal void _003COnClickReceive_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReceive_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MissionItem _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

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

	[SerializeField]
	private Image _missionTypeImage;

	[SerializeField]
	private Text _missionTypeText;

	[SerializeField]
	private Text _NameText;

	[SerializeField]
	private Image _progressGaugeMaskImage;

	[SerializeField]
	private Text _progressText;

	[SerializeField]
	private Image _progressGaugeImage;

	[SerializeField]
	private Color _progressGaugeColor;

	[SerializeField]
	private Color _progressGaugeFullColor;

	[SerializeField]
	private ClickableShopItemIcon[] _rewardImages;

	[SerializeField]
	private Image[] _rewardSlotImages;

	[SerializeField]
	private Color _rewardSlotColor;

	[SerializeField]
	private Color _rewardSlotEmptyColor;

	[SerializeField]
	private ClickableShopItemIcon[] _passRewardImages;

	[SerializeField]
	private Image[] _passRewardLockImages;

	[SerializeField]
	private ConditionalBase[] _rewardButtonConditionals;

	[SerializeField]
	private Button _tutorialbutton;

	[SerializeField]
	private Button _shortCutButton;

	[SerializeField]
	private Button _disableButton;

	[SerializeField]
	private GameObject _clearedBlackMask;

	[SerializeField]
	private GameObject _lockedObject;

	private MissionPanel_Base _basePanel;

	private ResourceMission _resMission;

	private readonly List<GameObject> _rentedArtifactIcons;

	private bool _isLocked;

	public MissionData missionData { get; private set; }

	public int tabIdx { get; private set; }

	public void Init(MissionData missionData, int tabIdx, Color missionTypeImageColor, MissionPanel_Base basePanel)
	{
	}

	public void Reload()
	{
	}

	public void SetLocked(bool locked)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReceive_003Ed__35))]
	public void OnClickReceive()
	{
	}

	public void OnClickShortcut()
	{
	}
}
